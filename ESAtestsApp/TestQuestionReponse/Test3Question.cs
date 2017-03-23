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
    public partial class Test3QuestionForm : Form
    {
        public CalculTest TestEnCours;
        private string Operation;
        private int Reponse;
        private int Score;
        private int temps;

        // on récupère la difficulté
        public Test3QuestionForm()
        {
            InitializeComponent();
        }

        public Test3QuestionForm(CalculTest testencours,string operation)
        {
            TestEnCours= testencours;
            InitializeComponent();
            Operation = operation;
            Score = 0;
            temps = TestEnCours.DifficulteTest.TempsReponse ;

        }

        public Test3QuestionForm(string operation, int score)
        {
            InitializeComponent();
            Operation = operation;
            Score = score;

        }

        private void MenuPrincipalBtn_Click(object sender, EventArgs e)
        {
            AffichageRepTmr.Stop();
            TempsRepTmr.Stop();
            SecondeTmr.Stop();
            FiniTmr.Stop();
            if (MessageBox.Show("Êtes-vous sur?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Affichage du form Menu Principal
                MenuForm Menu = new MenuForm();
                Menu.Show();
                this.Hide();
            }
         
        }

        private void Generation_Calcul()
        {
            Random rand = new Random();
            if (Operation == "addition")
            {
                int add1 = rand.Next(100,999);
                int add2 = rand.Next(100, 999);
                Reponse = add1 + add2;

                EnnonceQuestionLb.Text = add1.ToString() + " + " + add2.ToString() + " =";
            }

            if (Operation == "soustraction")
            {
                int add1 = rand.Next(100, 999);
                int add2 = rand.Next(10, 999);
                while (add2 >= add1)
                    add2 = rand.Next(10, 999);
                Reponse = add1 - add2;

                EnnonceQuestionLb.Text = add1.ToString() + " - " + add2.ToString() + " =";
            }

            if (Operation == "multiplication")
            {
                int add1 = rand.Next(1, 99);
                int add2 = rand.Next(1, 10);
                Reponse = add1 * add2;

                EnnonceQuestionLb.Text = add1.ToString() + " x " + add2.ToString() + " =";
            }

            if (Operation == "division")
            {
                int add1 = rand.Next(10, 999);
                int add2 = rand.Next(1, 10);
                Reponse = (int)(add1 / add2);

                EnnonceQuestionLb.Text = add1.ToString() + " / " + add2.ToString() + " =";
            }
        }

        private void Test3QuestionForm_Load(object sender, EventArgs e)
        {
            
            Domain.Difficulte.NiveauDifficulte difficulte = Domain.Difficulte.NiveauDifficulte.Facile;
            if (TestEnCours.DifficulteTest.NivDifficulteTest == difficulte)
            {
                // on génère le calcul
                Generation_Calcul();
                OKBtn.Visible = true;
            }
            else
            {

                TempsLb.Text = "";
                TempsLb.Visible = true;
                EnnonceGb.Visible = false;
                ReponseGb.Visible = false;
                DemarerBtn.Visible = true;
            }

        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            Domain.Difficulte.NiveauDifficulte difficulte = Domain.Difficulte.NiveauDifficulte.Facile;
            if (TestEnCours.DifficulteTest.NivDifficulteTest == difficulte)
            {
                #region Facile
                // on commence par vérifier qu'on ne dépasse pas 10 questions
                if (TestEnCours.TabSerie[0].CompteurQ < TestEnCours.NbQparSerie)
                {
                    // on vérifie que la réponse donnée est la bonne
                    if (ReponseTextLb.Text == Reponse.ToString())
                    {
                        VraiOuFauxLb.Text = "Bonne réponse";
                        VraiOuFauxLb.ForeColor = Color.LimeGreen;
                        Score++;
                    }
                    else
                    {
                        VraiOuFauxLb.Text = "Mauvaise réponse" + "\nLa bonne réponse était " + Reponse.ToString();
                        VraiOuFauxLb.ForeColor = Color.Red;
                    }
                    
                    
                    VraiOuFauxLb.Visible = true;
                    OKBtn.Visible = false;
                    AffichageRepTmr.Start();
                }
                #endregion
            }

            else
            {
                TempsLb.Text =temps.ToString();
                TempsLb.Visible = true;
                SablierPb.Visible = true;
                SecondeTmr.Start();

                #region Difficile

                TempsRepTmr.Stop();
                SecondeTmr.Stop();
                TempsLb.Visible = false;
                SablierPb.Visible = false;
                // on commence par vérifier qu'on ne dépasse pas 10 questions
                if (TestEnCours.TabSerie[0].CompteurQ < TestEnCours.NbQparSerie)
                {
                    // on vérifie que la réponse donnée est la bonne
                    if (ReponseTextLb.Text == Reponse.ToString())
                    {
                        VraiOuFauxLb.Text = "Bonne réponse";
                        VraiOuFauxLb.ForeColor = Color.LimeGreen;
                    }
                    else
                    {
                        VraiOuFauxLb.Text = "Mauvaise réponse" + "\nLa bonne réponse était " + Reponse.ToString();
                        VraiOuFauxLb.ForeColor = Color.Red;
                    }

                VraiOuFauxLb.Visible = true;
                OKBtn.Visible = false;
                AffichageRepTmr.Start();

                }
                #endregion
            }
        }

        private void AffichageRepTmr_Tick(object sender, EventArgs e)
        {
            // On arrete le timer (qu'on relancera au prochain coup)
            AffichageRepTmr.Stop();

            //On réinitialise toute la page si on est pas a la dernière question
            if (TestEnCours.TabSerie[0].CompteurQ < TestEnCours.NbQparSerie - 1)
            {
                this.Controls.Clear();
                this.InitializeComponent();

                temps = TestEnCours.DifficulteTest.TempsReponse;
                TempsLb.Text =temps.ToString();
                SecondeTmr.Start();
                Generation_Calcul();
                TestEnCours.TabSerie[0].CompteurQ++;
                EnnonceGb.Text = "Question " + (TestEnCours.TabSerie[0].CompteurQ + 1).ToString() + "/10";
            }
            else
                FiniTmr.Start();             

            // Si on est en difficile on doit relancer le crono
            Domain.Difficulte.NiveauDifficulte difficulte = Domain.Difficulte.NiveauDifficulte.Difficile;
            if (TestEnCours.DifficulteTest.NivDifficulteTest == difficulte)
            {
                TempsRepTmr.Stop();
                Generation_Calcul();
                if (TestEnCours.TabSerie[0].CompteurQ != TestEnCours.NbQparSerie)
                    TempsRepTmr.Start();

                
                SablierPb.Visible = true;
                TempsLb.Visible = true;
            }
            OKBtn.Visible = true;
            
        }

        private void TempsRepTmr_Tick(object sender, EventArgs e)
        {
            TempsRepTmr.Stop();
            ReponseTextLb.Visible = false;
            OKBtn.Visible = false;
            VraiOuFauxLb.Visible = true;
            if ((ReponseTextLb.Text != "") && (int.Parse(ReponseTextLb.Text) == Reponse))
            {
                VraiOuFauxLb.ForeColor = Color.LimeGreen;
                VraiOuFauxLb.Text = "Bonne réponse";
                Score++;
            }
            else
            {
                VraiOuFauxLb.Text = "Alors on a pas eu le temps ?!" + "\nLa bonne réponse était " + Reponse.ToString();
                VraiOuFauxLb.ForeColor = Color.Red;
            }

            AffichageRepTmr.Start();
            SablierPb.Visible = false;
            TempsLb.Visible = false;
            SecondeTmr.Stop();
        }

        private void ReponseTextLb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int i = int.Parse(ReponseTextLb.Text);
            }
            catch
            {
                ReponseTextLb.Clear();
            }
        }

        private void FiniTmr_Tick(object sender, EventArgs e)
        {

            FiniTmr.Stop();
            SecondeTmr.Stop();
            AffichageRepTmr.Stop();
            TempsRepTmr.Stop();

            VraiOuFauxLb.Visible = false;
            MenuPrincipalBtn.Visible = false;
            EnnonceGb.Visible = false;
            ReponseGb.Visible = false;

            //affichage d'un pop-up
            int scorePourcentage = Score * 100 / TestEnCours.NbQparSerie;
            MessageBox.Show("Résultats du test : " + scorePourcentage + "% de réponses justes", "Résultats", MessageBoxButtons.OK);

            //enregistrement des résultats dans Scores
            string[] tab_score = new string[3];
            tab_score[0] = TestEnCours.NomTest;
            tab_score[1] = TestEnCours.DifficulteTest.NivDifficulteTest.ToString();
            tab_score[2] = scorePourcentage.ToString();
            Test.Scores.Add(tab_score);

            //retour au menu principal
            MenuForm Menu = new MenuForm();
            Menu.Show();
            this.Hide();

        }

        private void SecondeTmr_Tick(object sender, EventArgs e)
        {
            SecondeTmr.Stop();
            if (temps != 0)
            {
                SecondeTmr.Start();
                temps--;
            }

            TempsLb.Text = temps.ToString();
            
        }

        private void Test3Question_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DemarerLb_Click(object sender, EventArgs e)
        {
            EnnonceGb.Visible = true;
            ReponseGb.Visible = true;
            OKBtn.Visible = true;
            DemarerBtn.Visible = false;
            SablierPb.Visible = true;
            SecondeTmr.Start();
            TempsLb.Text = temps.ToString();
            TempsLb.Visible = true; 

            Generation_Calcul();
            TempsRepTmr.Start();
        }
    }
}
