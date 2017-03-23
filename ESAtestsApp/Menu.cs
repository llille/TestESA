using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; 
using System.Xml;
using System.Xml.Serialization;
using Domain;

namespace ESAtestsApp
{
    public partial class MenuForm : Form
    {

        public MenuForm()
        {
            InitializeComponent();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            //Création d'un objet Test 
            bool niv;
            if (FacileRadioBtn.Checked)
                niv=true;
            else
                niv=false;

            #region Création du bon test

                Test TestEnCours;   

                if (Test1RadioBtn.Checked)
                {
                    TestEnCours = new PerceptionTest(niv);
                }
                else if (Test2RadioBtn.Checked)
                {
                    TestEnCours = new AttentionTest(niv);
                }

                else if (Test3RadioBtn.Checked)
                {
                    TestEnCours = new CalculTest(niv);
                }

                else if (Test4RadioBtn.Checked)
                {
                    TestEnCours = new QCMTest(niv, "mathématiques");
                }

                else 
                {
                    TestEnCours = new QCMTest(niv, "physiques");
                }
            #endregion

            //Affichage du form Enonce
            EnonceForm Enonce = new EnonceForm(TestEnCours);
            Enonce.Show();
            this.Hide();
                

        }

        private void ScoresBtn_Click(object sender, EventArgs e)
        {
            //Affichage du form Score
            ScoreForm Score = new ScoreForm();
            Score.Show();
            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            //Cochage des tests
            foreach (string[] tab in Test.Scores)
            {
                if (tab[0] == "Perception et mémoire associative")
                {
                    if (tab[1] == "Facile")
                        Test1FCheckB.Checked = true;
                    else
                        Test1DCheckB.Checked = true;
                }

                if (tab[0] == "Attention et concentration")
                {
                    if (tab[1] == "Facile")
                        Test2FCheckB.Checked = true;
                    else
                        Test2DCheckB.Checked = true;
                }

                if (tab[0] == "Calcul mental")
                {
                    if (tab[1] == "Facile")
                        Test3FCheckB.Checked = true;
                    else
                        Test3DCheckB.Checked = true;
                }

                if (tab[0] == "Problèmes mathématiques")
                {
                    if (tab[1] == "Facile")
                        Test4FCheckB.Checked = true;
                    else
                        Test4DCheckB.Checked = true;
                }

                if (tab[0] == "Problèmes physiques")
                {
                    if (tab[1] == "Facile")
                        Test5FCheckB.Checked = true;
                    else
                        Test5DCheckB.Checked = true;
                }
            }

           
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }





    }
}
