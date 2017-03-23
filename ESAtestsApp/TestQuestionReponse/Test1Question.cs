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
    public partial class Test1QuestionForm : Form
    {
        #region Attributs

        private Test MonTest;

        private int[] BonneRepForme; // On stock la forme et la couleur demandé par la consigne (exemple : rond bleu)
        private List<int> BonneRepNum; // Permet de stocker les entiers inscrits dans les figures demandées

        private int nbBonneTotRep = 0; // compte le nombre de bonnes réponses donnée par l'utilisateur sur l'ensemble du test

        private int nbRep = 0; //contient le nombre de réponses a la question en cours
        private int nbTotRep = 0; // comme on peut avoir 3 ou 4 réponse par question on doit stocker le nombre de réponses total


        private int compte_question = 1; //permet de savoir a quelle question on en est


        private int temps = 0; // l'affichage en temps réel du temps restant

        Random rand = new Random();
        #endregion

        #region Constructeurs

        public Test1QuestionForm()
        {
            InitializeComponent();
        }

        public Test1QuestionForm(Test montest)
        {
            InitializeComponent();
            MonTest = montest;

            //on crée aléatoirement la bonne réponse pour la première série
            int forme = rand.Next(0, 2);
            int couleur = rand.Next(0, 2);
            int[] bonnerep = { forme, couleur };

            BonneRepForme = bonnerep;

            temps = MonTest.DifficulteTest.TempsAffichageQ;

        }

        #endregion

        private void Test1QuestionForm_Load(object sender, EventArgs e)
        {
            AffichageTmr.Interval = MonTest.DifficulteTest.TempsAffichageQ * 1000;
        }

        private void MenuPrincipalBtn_Click(object sender, EventArgs e)
        {
            //on arrete toutes les opérations en cours
            AffichageTmr.Stop();
            SecondeTmr.Stop();

            if (MessageBox.Show("Êtes-vous sur?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Affichage du form Menu Principal
                MenuForm Menu = new MenuForm();
                Menu.Show();
                this.Hide();
            }

        }

        private void DemarrerBtn_Click(object sender, EventArgs e)
        {
            DemarrerBtn.Visible = false;
            NumQuestionLb.Visible = true;
            QuestionGb.Visible = true;
            SablierPb.Visible = true;
            TempsLb.Visible = true;

            TempsLb.Text = temps.ToString();

            SablierPb.Visible = true;
            SecondeTmr.Start();
            AfficheRepTmr.Start();  //ici AfficheRepTmr.interval=1 afin que le premier affichage soit instantané


        }

        private void AfficheRepTmr_Tick(object sender, EventArgs e)
        {

            AfficheRepTmr.Interval = 2000;// on remet un affichage de la réponse a un temps de 2 sec
            AfficheRepTmr.Stop();
            SablierPb.Visible = true;

            #region Reinitialisation des éléments graphiques

            //On cache les textbox
            ReponseGb.Visible = false;
            Reponse4Tb.Visible = false;
            //On cache les messages d'erreur
            Reponse1vfLb.Visible = false;
            Reponse2vfLb.Visible = false;
            Reponse3vfLb.Visible = false;
            Reponse4vfLb.Visible = false;
            //On enlève les valeurs rentrée dans les textbox
            Reponse1Tb.Clear();
            Reponse2Tb.Clear();
            Reponse3Tb.Clear();
            Reponse4Tb.Clear();

            //On remet les label sur mauvaise réponse
            Reponse1vfLb.ForeColor = Color.Red;
            Reponse2vfLb.ForeColor = Color.Red;
            Reponse3vfLb.ForeColor = Color.Red;
            Reponse4vfLb.ForeColor = Color.Red;
            Reponse1vfLb.Text = "Mauvaise Réponse";
            Reponse2vfLb.Text = "Mauvaise Réponse";
            Reponse3vfLb.Text = "Mauvaise Réponse";
            Reponse4vfLb.Text = "Mauvaise Réponse";

            #endregion


            if (compte_question < MonTest.NbQparSerie + 1)// si on est pas a la dernière question
            {

                NumQuestionLb.Text = "Question " + compte_question.ToString() + "/" + MonTest.NbQparSerie.ToString();

                //on supprime les figures présentes précédement
                this.Refresh();

                #region Création du tableau de position des figures

                int[,] position = new int[12, 2];
                //On est sur de lignes donc les position ne sont pas propores a chaque point mais a une ligne et une colonne
                position[0, 0] = position[4, 0] = position[8, 0] = 127;
                position[0, 1] = position[1, 1] = position[2, 1] = position[3, 1] = 210;
                position[1, 0] = position[5, 0] = position[9, 0] = 301;
                position[2, 0] = position[6, 0] = position[10, 0] = 475;
                position[3, 0] = position[11, 0] = position[7, 0] = 650;
                position[4, 1] = position[5, 1] = position[6, 1] = position[7, 1] = 300;
                position[8, 1] = position[9, 1] = position[10, 1] = position[11, 1] = 390;

                #endregion

                // la taille de génération est 43;43 pour le rectangle et pour le cercle 
                int size = 43;

                #region Création d'une serie de figures conformes aux règles et tracé

                nbRep = 0;
                int[,] figures = new int[12, 3];
                while ((nbRep != 3) && (nbRep != 4)) //tant que la série ne contient pas 3 ou 4 bonne réponses on génère une autre série
                {
                    BonneRepNum = new List<int>();
                    nbRep = 0;
                    for (int i = 0; i < 12; i++)
                    {
                        int forme = rand.Next(0, 2);
                        int couleur = rand.Next(0, 2);
                        int numero = rand.Next(0, 10);

                        figures[i, 0] = forme;
                        figures[i, 1] = couleur;
                        figures[i, 2] = numero;
                        if ((forme == BonneRepForme[0]) && (couleur == BonneRepForme[1]))
                        {
                            BonneRepNum.Add(numero);
                            nbRep++;
                        }
                    }
                }

                #region Création de la consigne

                string Strforme;
                if (BonneRepForme[0] == 0)
                    Strforme = "rectangles";
                else
                    Strforme = "ronds";

                string Strcouleur;
                if (BonneRepForme[1] == 1)
                    Strcouleur = "bleus";
                else
                    Strcouleur = "jaunes";

                EnnonceQuestionLb.Text = "Retenez les chiffres écrits dans les " + Strforme + " " + Strcouleur + ".";

                #endregion

                //on trace les figures
                for (int i = 0; i < 12; i++)
                {
                    draw(i, figures[i, 0], figures[i, 1], figures[i, 2], position[i, 0], position[i, 1], size);
                }

                #endregion

                AffichageTmr.Start();

                compte_question++;
            }
            else
            {
                QuestionGb.Visible = false;
                MenuPrincipalBtn.Visible = false;
                SablierPb.Visible = false;
                
                int scorePourcentage = nbBonneTotRep * 100 / nbTotRep;


                //enregistrement des résultats dans Scores
                string[] tab_score = new string[3];
                tab_score[0] = MonTest.NomTest;
                tab_score[1] = MonTest.DifficulteTest.NivDifficulteTest.ToString();
                tab_score[2] = scorePourcentage.ToString();
                Test.Scores.Add(tab_score);

                //affichage d'un pop-up
                MessageBox.Show("Résultats du test : " + scorePourcentage + "% de réponses justes", "Résultats", MessageBoxButtons.OK);
                {
                    MenuForm Menu = new MenuForm();
                    Menu.Show();
                    this.Hide();
                }
            }
            TempsLb.Text = temps.ToString();
            TempsLb.Visible = true;
            SecondeTmr.Start();
        }

        private void draw(int num, int forme, int couleur, int numero, int x, int y, int size)
        {
            #region Dessin de la forme
            //on trace la bonne forme
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(x, y, size, size);

            SolidBrush Brush;
            if (couleur == 1) //bleu
                Brush = new SolidBrush(Color.Blue);
            else //Jaune
                Brush = new SolidBrush(Color.Yellow);

            if (forme == 0) //rectangle
            {
                graphics.DrawRectangle(System.Drawing.Pens.Black, rectangle);
                graphics.FillRectangle(Brush, rectangle);
            }
            else //cercle
            {
                graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
                graphics.FillEllipse(Brush, rectangle);
            }
            #endregion

            #region Dessin de l'entier dans la figure

            if (couleur == 1)// si la figure est remplie en bleu, on écrit en blanc pour une meilleure lisibilité
                Brush = new SolidBrush(Color.White);
            else
                Brush = new SolidBrush(Color.Black);

            Font Font = new Font("Arial", 16);
            RectangleF Rect = new RectangleF(x, y, size, size);
            Pen Pen = new Pen(Color.Black);

            // On place le texte au centre du rectangle
            StringFormat Format = new StringFormat();
            Format.Alignment = StringAlignment.Center;
            Format.LineAlignment = StringAlignment.Center;


            graphics.DrawString(numero.ToString(), Font, Brush, Rect, Format);

            #endregion

            #region Dessin du nom de la figure

            Brush = new SolidBrush(Color.White);
            Font = new Font("Arial", 10);
            Format.LineAlignment = StringAlignment.Near;
            RectangleF LettreRect = new RectangleF(x, y - 18, size, size); // on écrit juste au dessus de la figure

            //On utilise le code ASCII pour déterminer quelle lettre écrire
            var asciiBytes = new byte[] { (byte)(65 + num), 0, 0, 0 }; // on part de 65 car c'est le code ASCII de "A"
            var lettre = System.Text.Encoding.ASCII.GetString(asciiBytes);
            graphics.DrawString(lettre.ToString(), Font, Brush, LettreRect, Format);

            #endregion

        }

        private void AffichageTmr_Tick(object sender, EventArgs e)
        {
            TempsLb.Visible = false;
            AffichageTmr.Stop();

            this.Refresh();

            ReponseGb.Visible = true;
            if (nbRep == 4)
                Reponse4Tb.Visible = true;

            SablierPb.Visible = false;
            OKBtn.Visible = true;
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {

            //on crée la bonne réponse pour la nouvelle série 
            int forme = rand.Next(0, 2);
            int couleur = rand.Next(0, 2);
            int[] bonnerep = { forme, couleur };

            BonneRepForme = bonnerep;


            string[] rep_entrees; // va permettre de récuperer les réponses entrée par l'utilisateur

            Reponse1vfLb.Visible = true;
            Reponse2vfLb.Visible = true;
            Reponse3vfLb.Visible = true;
            if (nbRep == 3)
                rep_entrees = new string[3];
            else
            {
                Reponse4vfLb.Visible = true;
                rep_entrees = new string[4];
                rep_entrees[3] = Reponse4Tb.Text;
            }

            rep_entrees[0] = Reponse1Tb.Text;
            rep_entrees[1] = Reponse3Tb.Text;
            rep_entrees[2] = Reponse2Tb.Text;

            nbTotRep += nbRep;

            int j = Verif_rep(BonneRepNum, rep_entrees);

            OKBtn.Visible = false;

            temps = MonTest.DifficulteTest.TempsAffichageQ;
            SecondeTmr.Stop();
            AfficheRepTmr.Start();

        }

        public int Verif_rep(List<int> bonnes_rep, string[] rep_entrees)
        {
            bool[] tab_test = { false, false, false, false }; // tableau qui permet de ne pas comptabiliser deux fois une même réponse donné par l'utilisateur
            int NbBonneRep = 0;

            for (int i = 0; i < rep_entrees.Length; i++)
            {
                int j = 0;
                foreach (int num in bonnes_rep)
                {
                    if (i == 0)
                        Reponse1vfLb.Visible = true;
                    else if (i == 1)
                        Reponse2vfLb.Visible = true;
                    else if (i == 2)
                        Reponse3vfLb.Visible = true;
                    else if (i == 3)
                        Reponse4vfLb.Visible = true;

                    // dans le cas ou l'utilisateur ne rentre rien on considère qu'il a rentré -1
                    try
                    {
                        int.Parse(rep_entrees[i]);
                    }
                    catch
                    {
                        rep_entrees[i] = "-1";
                    }


                    if ((num == int.Parse(rep_entrees[i]) && (NbBonneRep <= i)) && (tab_test[j] == false))
                    // la deuxième condition permet de vérifier qu'on a pas plus de bonnes réponse que de réponses étudiées
                    // le troisième condition permet de vérifier que si l'utilisateur rentre 4,4,4 il n'ai pas bon a tous
                    {
                        NbBonneRep++;
                        if (i == 0)
                        {
                            Reponse1vfLb.Visible = true;
                            Reponse1vfLb.Text = "Bonne Réponse";
                            Reponse1vfLb.ForeColor = Color.LimeGreen;
                        }
                        else if (i == 1)
                        {
                            Reponse2vfLb.Visible = true;
                            Reponse2vfLb.Text = "Bonne Réponse";
                            Reponse2vfLb.ForeColor = Color.LimeGreen;
                        }
                        else if (i == 2)
                        {
                            Reponse3vfLb.Visible = true;
                            Reponse3vfLb.Text = "Bonne Réponse";
                            Reponse3vfLb.ForeColor = Color.LimeGreen;
                        }
                        else if (i == 3)
                        {
                            Reponse4vfLb.Visible = true;
                            Reponse4vfLb.Text = "Bonne Réponse";
                            Reponse4vfLb.ForeColor = Color.LimeGreen;
                        }

                        tab_test[j] = true;
                    }
                    j++;
                }

            }

            nbBonneTotRep += NbBonneRep;
            return (NbBonneRep);
        }

        private void SecondeTmr_Tick(object sender, EventArgs e) // permet d'afficher un chrono qui fait le décompte en temps réel
        {
            SecondeTmr.Stop();
            if (temps != 0)
            {
                SecondeTmr.Start();
                temps--;
            }

            TempsLb.Text = temps.ToString();
        }

        #region Efface tout ce qui n'est pas des lettre dans les textbox

        private void Reponse1TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(Reponse1Tb.Text);
            }
            catch
            {
                Reponse1Tb.Clear();
            }
        }

        private void Reponse2TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(Reponse2Tb.Text);
            }
            catch
            {
                Reponse2Tb.Clear();
            }
        }

        private void Reponse3TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(Reponse3Tb.Text);
            }
            catch
            {
                Reponse3Tb.Clear();
            }
        }

        private void Reponse4TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(Reponse4Tb.Text);
            }
            catch
            {
                Reponse4Tb.Clear();
            }
        }

        #endregion

        private void Test1Question_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



    }
}
