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
    public partial class Test45QuestionForm : Form
    {
        #region Attributs

            private Test TestEnCours;
            private int score=0;
            private bool repbonne=false;

        #endregion

        #region Constructeurs

            public Test45QuestionForm()
        {
            InitializeComponent();
        }

        public Test45QuestionForm(Test testencours)
        {
            InitializeComponent();
            TestEnCours = testencours;
        }

            #endregion


        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sur?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Affichage du form Menu Principal
                MenuForm Menu = new MenuForm();
                Menu.Show();
                this.Hide();
            }
        }

        private void Test45QuestionForm_Load(object sender, EventArgs e)
        {
            ChargementPage();
        }

        private void ChargementPage()
        {
            this.Text = "Test ESA - " + TestEnCours.NomTest;

            if (TestEnCours.NomTest == "Problèmes mathématiques")
            {
                TitreLb.Text = "Problèmes mathématiques";
            }
            else
            {
                TitreLb.Text = "Problèmes physiques";
            }

            EnonceGrB.Text = "Question n°" + (TestEnCours.TabSerie[0].CompteurQ + 1) + "/" + TestEnCours.NbQparSerie;
            EnonceLb.Text = TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].EnnonceTexte;

            //affichage image
            if (TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].Image == "")
            { }
            else
            {
                EnonceImg.Visible = true;
                EnonceImg.ImageLocation = "../../../Ressources/Images/" + TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].Image;
            }

            //Si la question ne propose pas toutes les réponse, on cache les boutons inutiles
            if (TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].TabReponses[0] == "PasDeReponse")
                Reponse1Btn.Visible = false;
            if (TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].TabReponses[1] == "PasDeReponse")
                Reponse2Btn.Visible = false;
            if (TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].TabReponses[2] == "PasDeReponse")
                Reponse3Btn.Visible = false;
            if (TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].TabReponses[3] == "PasDeReponse")
                Reponse4Btn.Visible = false;

            Reponse1Btn.Text = TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].TabReponses[0];
            Reponse2Btn.Text = TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].TabReponses[1];
            Reponse3Btn.Text = TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].TabReponses[2];
            Reponse4Btn.Text = TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].TabReponses[3];
        }

        #region Gestion des boutons réponse

            private void Reponse1Btn_Click(object sender, EventArgs e)
        {
            ClickBoutonReponse(1);
        }
            private void Reponse2Btn_Click(object sender, EventArgs e)
        {
            ClickBoutonReponse(2);
        }
            private void Reponse3Btn_Click(object sender, EventArgs e)
        {
            ClickBoutonReponse(3);
        }
            private void Reponse4Btn_Click(object sender, EventArgs e)
        {
            ClickBoutonReponse(4);
        }

            private void ClickBoutonReponse(int numBouton)
        {
            if (numBouton == 1)
            {
                Reponse1Btn.Enabled = false;
                //on cache les autres boutons réponses
                Reponse2Btn.Visible = false;
                Reponse3Btn.Visible = false;
                Reponse4Btn.Visible = false;
            }
            else if (numBouton==2)
            {
                Reponse2Btn.Enabled = false;
                //on cache les autres boutons réponses
                Reponse1Btn.Visible = false;
                Reponse3Btn.Visible = false;
                Reponse4Btn.Visible = false;
                }
            else if (numBouton == 3)
            {
                Reponse3Btn.Enabled = false;
                //on cache les autres boutons réponses
                Reponse1Btn.Visible = false;
                Reponse2Btn.Visible = false;
                Reponse4Btn.Visible = false;
            }

            else if(numBouton == 4)
            {
                Reponse4Btn.Enabled = false;
                //on cache les autres boutons réponses
                Reponse1Btn.Visible = false;
                Reponse2Btn.Visible = false;
                Reponse3Btn.Visible = false;
            }

            //on affiche le bouton suivant
            SuivantBtn.Visible = true;

            bool[] BoutonBonneRep = {Reponse1Btn.Text == TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].BonneRep,
                                        Reponse2Btn.Text == TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].BonneRep,
                                        Reponse3Btn.Text == TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].BonneRep,
                                        Reponse4Btn.Text == TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].BonneRep};



            if (BoutonBonneRep[numBouton-1])
            {
                    VraiOuFauxLb.Text = "Bonne réponse";
                    VraiOuFauxLb.ForeColor = Color.LimeGreen;
                    repbonne = true;
            }
            else
            {
                VraiOuFauxLb.ForeColor = Color.Red;
                VraiOuFauxLb.Text = "Mauvaise réponse : il fallait répondre " + TestEnCours.TabSerie[0].TabQuestion[TestEnCours.TabSerie[0].CompteurQ].BonneRep;
            }
            VraiOuFauxLb.Visible = true;
        }

        #endregion

        private void SuivantBtn_Click(object sender, EventArgs e)
        {
            //on met a jour le score
            if (repbonne == true)
            {
                score++;
                repbonne = false;
            }

            TestEnCours.TabSerie[0].CompteurQ++;

            //Si on est pas encore à la dernière question
            if (TestEnCours.TabSerie[0].CompteurQ < 10)
            {
                this.Controls.Clear();
                InitializeComponent();
                if (TestEnCours.TabSerie[0].CompteurQ == 9) //si on est à l'avant dernière question
                    SuivantBtn.Text = "Fin du test";

                ChargementPage();
            }
            
            //Si on est à la dernière question de la série
            else
            {
                //affichage d'un pop-up
                int scorePourcentage = score * 100 / TestEnCours.NbQparSerie;
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
        }

        private void Test45_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
