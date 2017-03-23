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
    public partial class EnonceForm : Form
    {
        private Test TestEnCours;

        public EnonceForm()
        {
            InitializeComponent();
        }

        public EnonceForm(Test leTest)
        {
            InitializeComponent();
            TestEnCours = leTest;
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            //Affichage du form Menu Principal
            MenuForm Menu = new MenuForm();
            Menu.Show();
            this.Hide();
        }

        private void LancerBtn_Click(object sender, EventArgs e)
        {
            if (TestEnCours.NomTest == "Attention et concentration")
            {
                //Affichage du form Serie
                SerieForm Serie = new SerieForm(TestEnCours);
                Serie.Show();
                this.Hide();
            }
            else if (TestEnCours.NomTest == "Perception et mémoire associative")
                {
                    Test1QuestionForm QR = new Test1QuestionForm(TestEnCours);
                    QR.Show();
                }
            else if (TestEnCours.NomTest == "Calcul mental")
            {
                CalculTest testencours = (CalculTest)(TestEnCours);
                Test3OperationForm QR = new Test3OperationForm(testencours);
                QR.Show();
            }
            else if ((TestEnCours.NomTest == "Problèmes mathématiques") || (TestEnCours.NomTest == "Problèmes physiques"))
            {
                Test45QuestionForm QR = new Test45QuestionForm(TestEnCours);
                QR.Show();
            }
            this.Hide();
        }

        private void EnonceForm_Load(object sender, EventArgs e)
        {
            this.Text = "Test ESA - "+TestEnCours.NomTest;

            TitreLb.Text = TestEnCours.NomTest + " - Enoncé";

            EnonceLb.Text = TestEnCours.Ennonce;
            ExempleLb.Text = TestEnCours.Exemple;

            //On charge les images des exemples
            if (TestEnCours.NomTest == "Perception et mémoire associative")
                ExempleImg.ImageLocation = "../../../Ressources/Images/Test1_Exemple.jpg";

            else if (TestEnCours.NomTest == "Attention et concentration")
                ExempleImg.ImageLocation = "../../../Ressources/Images/Test2_Exemple.jpg";

            else if (TestEnCours.NomTest == "Calcul mental")
                ExempleImg.ImageLocation = "../../../Ressources/Images/Test3_Exemple.jpg";

            else if (TestEnCours.NomTest == "Problèmes mathématiques")
                ExempleImg.ImageLocation = "../../../Ressources/Images/Test4_Exemple.jpg";

            else if (TestEnCours.NomTest == "Problèmes physiques")
                ExempleImg.ImageLocation = "../../../Ressources/Images/Test5_Exemple.jpg";

            //change difficulté
            DifficulteGrB.Text = "Difficulé choisie : " + TestEnCours.DifficulteTest.NivDifficulteTest;
            DifficulteLb.Text = TestEnCours.DifficulteTest.RegleDifficulte;


        }

        private void TestEnonce_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
