using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain;

namespace ESAtestsApp
{
    public partial class Test2QuestionForm : Form
    {

        #region Attributs 

            private Test MonTest;

            // A LIRE : fonctionnement des règles dans le form
            // ce tableau contient en case 0 la règle pour le bouton 1
            // et en case 1 la règle pour le bouton 2 et la case 3 la règle du bouton 3 (celle qui reste)
            //exemple : si règle ={1,3,2} alors la règle pour le bouton 1 est la règle 1, la règle pour le bouton 2 est la règle 3 et la règle pour le bouton 3 et la règle 2
            // la règle 1 -> même forme
            // la règle 2 -> même couleur
            // la règle 3 -> même nombre de points
            private int[] regle=new int[3];
        
            // A LIRE : fonctionnement des figures dans le form
            // Chaque figures est un tableau de trois entiers 
            //exemple : firgure1 = {1,3,4}
            // la forme de figure1 est 1 (soit un carré)
            // la couleur de figure1 est 3 (soit rouge)
            // le nombre de points de figure1 est 4 (il y a 4 points dans le carré rouge)
            //le tableau figure est une matrice contenant toutes les figures de la série
            private int[,] figure; // contient la liste des figures qui vont être générées

            //Donne la séquence des boutons attendu lors de la génération des figures
            private int[] SequenceBouton = { 3, 0, 0, 0, 0 }; 

            private int compte_question=0;
 
            private int score = 0; // ce score contient le score de la série en cours
            private int score_tot = 0; // contient le score des séries précédentes

            private int temps = 0; // l'affichage en temps réel du temps restant

            Random rand = new Random();



        #endregion

        #region Constructeurs

            public Test2QuestionForm()
            {
                InitializeComponent();
            }

            public Test2QuestionForm(Test montest)
            {
                InitializeComponent();
                MonTest=montest;
                temps = MonTest.DifficulteTest.TempsReponse;
            }

            //Utilisé pour les séries 2 et 3 du test en difficulté Facile  
            public Test2QuestionForm(Test montest, int Score,int[] regle_serie)
            {
                InitializeComponent();
                MonTest = montest;
                score_tot = Score;
                regle = regle_serie;
            }

            //Utilisé pour les séries 2 et 3 du test en difficulté Difficile
            public Test2QuestionForm(Test montest, int[] regle_serie)
        {
            InitializeComponent();
            MonTest = montest;
            score_tot = 0;
            regle = regle_serie;

        }

        #endregion

        private void Test2QuestionForm_Load(object sender, EventArgs e)
        {
            #region Ecriture des consignes
                string btnForme="";
                if (regle[0] == 1)
                    btnForme= "Butt1";
                if (regle[1] == 1)
                    btnForme= "Butt2";
            
                string btnCouleur="";
                if (regle[0] == 2)
                    btnCouleur= "Butt1";
                if (regle[1] == 2)
                    btnCouleur= "Butt2";

                // on veut être sur que la consigne affiche les consignes pour butt1 puis butt2
                if (btnForme == "Butt1")
                    EnnonceQuestionLb.Text = "butt1 : Cette figure et la précédente ont la même forme.";
                else if (btnCouleur=="Butt1")
                    EnnonceQuestionLb.Text = "butt1 : Cette figure et la précédente ont la même couleur.";
                else
                    EnnonceQuestionLb.Text = "butt1 : Cette figure et la précédente ont le même nombre de points.";

                if (btnForme=="Butt2")
                    EnnonceQuestionLb.Text += "\nbutt2 : Cette figure et la précédente ont la même forme.";
                else if (btnCouleur == "Butt2")
                    EnnonceQuestionLb.Text += "\nbutt2 : Cette figure et la précédente ont la même couleur.";
                else
                    EnnonceQuestionLb.Text += "\nbutt2 : Cette figure et la précédente ont le même nombre de points.";

                EnnonceQuestionLb.Text += "\nbutt3 : Dans tous les autres cas.";
            #endregion


            //On génère le tableau de figure et la bonne séquence de boutons
            genereFigure();

            Domain.Difficulte.NiveauDifficulte difficulte = Domain.Difficulte.NiveauDifficulte.Difficile;
            if (MonTest.DifficulteTest.NivDifficulteTest == difficulte)
                SablierPb.Visible = true;

            AfficheOnLoadTmr.Start();
            try
            {
                TempsRepTmr.Interval = MonTest.DifficulteTest.TempsReponse * 1000;
            }
            catch
            {

            }
        }

        private void MenuPrincipalBtn_Click(object sender, EventArgs e)
        {
            //On s'assure qu'un clique sur menu arrete toutes les opération en cours
            AffichageRepTmr.Stop();
            TempsRepTmr.Stop();
            AfficheOnLoadTmr.Stop();


            if (MessageBox.Show("Êtes-vous sur?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Affichage du form Menu Principal
                MenuForm Menu = new MenuForm();
                Menu.Show();
                this.Hide();
            }
        }

        public void genereFigure() // génère le tableau des figures ainsi que la séquence bonne séquence de boutons
        {
            figure = new int[5, 3];
            //La première figure n'a aucune condition a vérifier on peut donc la générer d'abord
            figure[0, 0] = rand.Next(1, 4);
            figure[0, 1] = rand.Next(1, 5);
            figure[0, 2] = rand.Next(0, 5);

            // s'assure qu'on clique au moins une fois sur chaque bouton lors de l'execution d'une série
            bool SequenceValide = false;
            while (!SequenceValide)
            {
                for (int i = 1; i < 5; i++) // on commence a 1 car on a déja généré la première figure
                {
                    // on génère la nouvelle figure
                    figure[i, 0] = rand.Next(1, 4);
                    figure[i, 1] = rand.Next(1, 5);
                    figure[i, 2] = rand.Next(0, 5);

                    // on vérifie qu'elle n'a pas plus d'une similitude avec la précédente
                    bool Differente = false;
                    while (!Differente)
                    {
                        if ((figure[i, 0] == figure[(i - 1), 0]) && (figure[i, 1] == figure[(i - 1), 1])) //Pas la même forme ni la même couleur
                        {
                            figure[i, 0] = rand.Next(1, 4);
                            figure[i, 1] = rand.Next(1, 5);
                            figure[i, 2] = rand.Next(0, 5);
                        }
                        else if ((figure[i, 0] == figure[(i - 1), 0]) && (figure[i, 2] == figure[(i - 1), 2])) // Pas la même forme ni le même nombre de point
                        {
                            figure[i, 0] = rand.Next(1, 4);
                            figure[i, 1] = rand.Next(1, 5);
                            figure[i, 2] = rand.Next(0, 5);
                        }
                        else if ((figure[i, 1] == figure[(i - 1), 1]) && (figure[i, 2] == figure[(i - 1), 2])) // Pas la même couleur ni le même nobre de points
                        {
                            figure[i, 0] = rand.Next(1, 4);
                            figure[i, 1] = rand.Next(1, 5);
                            figure[i, 2] = rand.Next(0, 5);
                        }
                        else
                            Differente = true;
                    }

                }

                // on génère la suite des simlitudes entre les cases du tableau (si c'est -1 ça veut dire rien en commun)
                // si les deux premières figures ont la même forme alors similitude commencera pas {-1,1,...}
                int[] similitudes = { -1, -1, -1, -1, -1 };
                for (int i = 1; i < 5; i++)
                {
                    if (figure[i, 0] == figure[(i - 1), 0])
                        similitudes[i] = 1;
                    else if (figure[i, 1] == figure[(i - 1), 1])
                        similitudes[i] = 2;
                    else if (figure[i, 2] == figure[(i - 1), 2])
                        similitudes[i] = 3;
                }

                //on génère la séquence de boutons en fonction des règles de la série
                for (int i = 1; i < 5; i++)
                {
                    if (similitudes[i] == regle[0])
                        SequenceBouton[i] = 1;
                    else if (similitudes[i] == regle[1])
                        SequenceBouton[i] = 2;
                    else
                        SequenceBouton[i] = 3;
                }

                //On vérifie qu'il y a bien au moins un click sur chaque le bouton 1 et un sur le bouton 2
                bool Bouton1 = false;
                bool Bouton2 = false;
                for (int i = 1; i < 5; i++)
                {
                    if (SequenceBouton[i] == 1)
                        Bouton1 = true;
                    else if (SequenceBouton[i] == 2)
                        Bouton2 = true;
                }
                if (Bouton1 && Bouton2)
                    SequenceValide = true;
            }// On recommence jusqu'a avoir un série de figure possédant tous les critères
        }

        private void AfficheOnLoadTmr_Tick(object sender, EventArgs e) // permet l'affichage de la première figure dans le load car interval=1
        {
            AfficheOnLoadTmr.Stop();
            Draw();
        }

        private void Draw()
        {
            Graphics graphics = this.CreateGraphics();


            // le grand rectangle qui entoure tout
            graphics.DrawRectangle(new Pen(Color.White, 2), 58, 275, 718, 180);


            //Génération de la couleur
            SolidBrush Brush;
            if (figure[compte_question,1] == 1) // bleu
                Brush = new SolidBrush(Color.Blue);
            else if (figure[compte_question, 1] == 2) //jaune
                Brush = new SolidBrush(Color.Yellow);
            else if (figure[compte_question, 1] == 3) // rouge
                Brush = new SolidBrush(Color.Red);
            else
                Brush = new SolidBrush(Color.Green);


            //Génération de la forme
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(220, 320, 90, 90);

            if (figure[compte_question, 0] == 1)//rectangle
            {
                graphics.DrawRectangle(System.Drawing.Pens.Black, rectangle);
                graphics.FillRectangle(Brush, rectangle);
            }
            else if (figure[compte_question, 0] == 2) // cercle
            {
                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
                graphics.FillEllipse(Brush, rectangle);
            }
            else // triangle
            {
                Point v1 = new Point(220, 320);
                Point v2 = new Point(220, 410);
                Point v3 = new Point(298, 365);
                Pen p = new Pen(Brush, 4);
                graphics.DrawLine(p, v1, v2);
                graphics.DrawLine(p, v3, v2);
                graphics.DrawLine(p, v3, v1);
                graphics.FillPolygon(Brush, new Point[] { v1, v2, v3 });
            }

            #region Génération des position des points en fonction de leur nombre
            List<Point> PosPoints = new List<Point>();
            if (figure[compte_question, 2] == 1)
            {
                if (figure[compte_question, 0] == 3)
                    PosPoints.Add(new Point(240, 360));
                else
                    PosPoints.Add(new Point(260, 360));
            }
            else if (figure[compte_question, 2] == 2)
            {
                if (figure[compte_question, 0] == 3)
                {
                    PosPoints.Add(new Point(240, 345));
                    PosPoints.Add(new Point(240, 375));
                }
                else
                {
                    PosPoints.Add(new Point(260, 340));
                    PosPoints.Add(new Point(260, 380));

                }
            }
            else if (figure[compte_question, 2] == 3)
            {
                if (figure[compte_question, 0] == 3)
                {
                    PosPoints.Add(new Point(230, 345));
                    PosPoints.Add(new Point(230, 375));
                    PosPoints.Add(new Point(250, 360));
                }
                else
                {
                    PosPoints.Add(new Point(260, 335));
                    PosPoints.Add(new Point(260, 360));
                    PosPoints.Add(new Point(260, 385));
                }
            }
            else if (figure[compte_question, 2] == 4)
            {
                if (figure[compte_question, 0] == 3)
                {
                    PosPoints.Add(new Point(225, 345));
                    PosPoints.Add(new Point(225, 375));
                    PosPoints.Add(new Point(245, 345));
                    PosPoints.Add(new Point(245, 375));
                }
                else
                {
                    PosPoints.Add(new Point(243, 343));
                    PosPoints.Add(new Point(276, 343));
                    PosPoints.Add(new Point(243, 376));
                    PosPoints.Add(new Point(276, 376));
                }
            }
            #endregion
            
            //On trace les points, on change la couleur en fonction 
            foreach (Point point in PosPoints)
            {
                System.Drawing.Rectangle Rectpoint = new System.Drawing.Rectangle(point.X, point.Y, 10, 10);

                if (figure[compte_question, 1] == 1)
                {
                    graphics.DrawEllipse(System.Drawing.Pens.White, Rectpoint);
                    graphics.FillEllipse(new SolidBrush(Color.White), Rectpoint);
                }
                else
                {
                    graphics.DrawEllipse(System.Drawing.Pens.Black, Rectpoint);
                    graphics.FillEllipse(new SolidBrush(Color.Black), Rectpoint);
                }
            }
        }

        #region Click sur les boutons réponse
        private void boutonReponse(int i)
        {
            TempsRepTmr.Stop();

            int b = SequenceBouton[compte_question];
            if (b == i)
            {
                VraiOuFauxLb.Text = "OK";
                VraiOuFauxLb.ForeColor = Color.LimeGreen;
                score++;
            }
            else
            {
                VraiOuFauxLb.ForeColor = Color.Red;
                VraiOuFauxLb.Text = "FAUX, il fallait appuyer sur butt" + b.ToString();
            }
            VraiOuFauxLb.Visible = true;
            AffichageRepTmr.Start();
            Choix1Btn.Visible = false;
            Choix2Btn.Visible = false;
            Choix3Btn.Visible = false;

        } // une méthode qui permet de centraliser le code des click sur chaques boutons réponse

        private void Choix1Btn_Click(object sender, EventArgs e)
        {
            boutonReponse(1);
        } 

        private void Choix2Btn_Click(object sender, EventArgs e)
        {
            boutonReponse(2);
        }

        private void Choix3Btn_Click(object sender, EventArgs e)
        {
            boutonReponse(3);
            Domain.Difficulte.NiveauDifficulte difficulte = Domain.Difficulte.NiveauDifficulte.Difficile;
            if ((MonTest.DifficulteTest.NivDifficulteTest == difficulte)&&(compte_question==1))
               TimeLb.Visible = true;

        }

        #endregion

        private void AffichageRepTmr_Tick(object sender, EventArgs e)
        {
            AffichageRepTmr.Stop();
            compte_question++;

            if((compte_question+1)<=MonTest.NbQparSerie)
                NumQuestionLb.Text = "Question " + (compte_question+1).ToString() + "/" + MonTest.NbQparSerie.ToString();
            
            Choix1Btn.Visible = true;
            Choix2Btn.Visible = true;
            Choix3Btn.Visible = true;

            VraiOuFauxLb.Visible = false;

            this.Refresh();

            // on retrace le grand rectangle qui entoure tout
            Graphics graphics = this.CreateGraphics();
            graphics.DrawRectangle(new Pen(Color.Black, 1), 60, 200, 540, 160);


            if (compte_question < MonTest.NbQparSerie)// si on est entrain de répondre aux questions de 1 à 4
            {
                //cas difficile
                Domain.Difficulte.NiveauDifficulte difficulte = Domain.Difficulte.NiveauDifficulte.Difficile;
                if (MonTest.DifficulteTest.NivDifficulteTest == difficulte)
                {
                    TempsRepTmr.Start();

                    temps = MonTest.DifficulteTest.TempsReponse;
                    TimeLb.Text = temps.ToString();
                    TimeLb.Visible = true;
                    SecondeTmr.Start();
                }

                Draw();
            }
            else // lorsqu'on répond à la question 5
            {
                Choix1Btn.Visible = false;
                Choix2Btn.Visible = false;
                Choix3Btn.Visible = false;

                
                string message;
                if (MonTest.CompteurSerie < 3) // si on réalise les séries 1 ou 2
                {
                    int scorePourcentage = score * 100 / MonTest.NbQparSerie;
                    message = "Résultats du test pour cette série : " + scorePourcentage + "% de réponses justes";
                }
                else //lorsqu'on réalise la dernière série
                {
                    MenuPrincipalBtn.Visible = false;
                    QuestionGb.Visible = false;
                    ReponseLb.Visible = false;
                    SablierPb.Visible = false;
                    TimeLb.Visible = false;

                    int scorePourcentage = ((score+score_tot) * 100) / (MonTest.NbQparSerie*3);
                    
                    //on ajoute le score dutest au tableau Scores de la class Test
                    string[] tab_score = new string[3];
                    tab_score[0] = MonTest.NomTest;
                    tab_score[1] = MonTest.DifficulteTest.NivDifficulteTest.ToString();
                    tab_score[2] = scorePourcentage.ToString();
                    Test.Scores.Add(tab_score);
                    
                    // on créé le message
                    message = "Résultats du test pour toute les séries : " + scorePourcentage + "% de réponses justes";
                }

                MessageBox.Show(message, "Résultats", MessageBoxButtons.OK);
                {
                    if (MonTest.CompteurSerie < 3)
                    {
                        Domain.Difficulte.NiveauDifficulte difficulte = Domain.Difficulte.NiveauDifficulte.Difficile;
                        if (MonTest.DifficulteTest.NivDifficulteTest == difficulte)
                        {
                            // dans le cas difficile on a pas besoin de passer la règle en paramètre 
                            SerieForm Serie = new SerieForm(MonTest, (score + score_tot));
                            Serie.Show();
                            this.Hide();
                        }
                        else
                        {
                            //dans le cas facile, on a besoin de passer la règle en paramètre
                            SerieForm Serie = new SerieForm(MonTest, (score + score_tot),regle);
                            Serie.Show();
                            this.Hide();
                        }

                    }
                    else // lorsqu'on a fini le test en renvoie au menu
                    {
                        MenuForm Menu = new MenuForm();
                        Menu.Show();
                        this.Hide(); 
                    }
                }
            }
        }

        private void TempsRepTmr_Tick(object sender, EventArgs e) //permet de gérer le temps de réponse dans le cas difficile
        {
            TempsRepTmr.Stop();

            Choix1Btn.Visible = false;
            Choix2Btn.Visible = false;
            Choix3Btn.Visible = false;


            VraiOuFauxLb.Text = "Trop tard ... il fallait appuyer sur butt" + SequenceBouton[compte_question].ToString();
            VraiOuFauxLb.ForeColor = Color.Red;
            VraiOuFauxLb.Visible = true;

            TimeLb.Visible = false;
            AffichageRepTmr.Start();
        }

        private void SecondeTmr_Tick(object sender, EventArgs e)
        {
            SecondeTmr.Stop();
            if (temps != 0)
            {
                SecondeTmr.Start();
                temps--;
            }

            TimeLb.Text = temps.ToString();
        }


        private void Test2Question_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
