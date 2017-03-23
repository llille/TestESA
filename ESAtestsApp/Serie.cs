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
    public partial class SerieForm : Form
    {
        private Test TestEnCours;
        private Serie SerieEnCours;
        //Attributs utils pour le Test2 (Attention) uniquement
        int Score;
        int[] Regle={-1,-1,-1}; // on le remplit de -1 ce qui permet de vérifier rapidement s'il a déjà été rempli


        #region Constructeurs

        public SerieForm()
        {
            InitializeComponent();
        }

        public SerieForm(Test leTest)
        {
            InitializeComponent();
            TestEnCours = leTest;
            SerieEnCours=TestEnCours.TabSerie[TestEnCours.CompteurSerie];
        }

        //Constructeur utils pour le Test2 (Attention) uniquement
        public SerieForm(Test leTest, int score) // constructeur uniquement utile pour le test 2
        {
            InitializeComponent();
            TestEnCours = leTest;
            SerieEnCours = TestEnCours.TabSerie[TestEnCours.CompteurSerie];
            Score = score;
        }
        public SerieForm(Test leTest, int score,int[] regle) // constructeur uniquement utile pour le test 2
        {
            InitializeComponent();
            TestEnCours = leTest;
            SerieEnCours = TestEnCours.TabSerie[TestEnCours.CompteurSerie];
            Score = score;
            Regle = regle;
        }

        #endregion

        private void SerieForm_Load(object sender, EventArgs e)
        {
            GenereRegle();
            this.Text = "Test ESA - " + TestEnCours.NomTest;
            TitreLb.Text = TestEnCours.NomTest;
            NumSerieLb.Text = "Série n°" + (TestEnCours.CompteurSerie + 1)+"/"+TestEnCours.NbSerie;
            if (Regle[0] != -1)
                Consigne1Lb.Visible = true;
            
            string consigne;

            #region Ecriture des consignes
            string btnForme = "";
            if (Regle[0] == 1)
                btnForme = "Butt1";
            if (Regle[1] == 1)
                btnForme = "Butt2";

            string btnCouleur = "";
            if (Regle[0] == 2)
                btnCouleur = "Butt1";
            if (Regle[1] == 2)
                btnCouleur = "Butt2";

            // on veut être sur que la consigne affiche les consignes pour butt1 puis butt2
            if (btnForme == "Butt1")
                consigne = "butt1 : Cette figure et la précédente ont la même forme. ";
            else if (btnCouleur == "Butt1")
                consigne = "butt1 : Cette figure et la précédente ont la même couleur.";
            else
                consigne = "butt1 : Cette figure et la précédente ont le même nombre de points.";

            if (btnForme == "Butt2")
                consigne += "\nbutt2 : Cette figure et la précédente ont la même forme.";
            else if (btnCouleur == "Butt2")
                consigne += "\nbutt2 : Cette figure et la précédente ont la même couleur.";
            else
                consigne += "\nbutt2 : Cette figure et la précédente ont le même nombre de points.";

            consigne += "\nbutt3 : Dans tous les autres cas.";
            #endregion

            Consigne1Lb.Text = "Les 3 boutons correspondent à : \n\n" + consigne;
            Consigne1Lb.Visible = true;
        }

        private void GenereRegle()
        {
            Random rand = new Random();
            //Si on se trouve dans le cas difficile il faut a chaque série initialiser les règles 
            //Si on réalise la première série en difficulté Facile, on doit crée les règles pour les séries suivantes
            Domain.Difficulte.NiveauDifficulte difficulte = Domain.Difficulte.NiveauDifficulte.Difficile;
            if ((TestEnCours.DifficulteTest.NivDifficulteTest == difficulte) || (TestEnCours.CompteurSerie == 0))
            {
                // On crée règle
                int r = rand.Next(1, 4);
                Regle[0] = r;

                while (r == Regle[0])
                    r = rand.Next(1, 4);
                Regle[1] = r;

                //on s'assure que la règle mise dans regle[2] est différente des deux précédente
                // pour cela on crée une liste des 3 règles auquelle on retire regle[0] et regle[1]
                List<int> reste = new List<int> { 1, 2, 3 };
                reste.Remove(Regle[0]);
                reste.Remove(Regle[1]);
                Regle[2] = reste[0];
            }
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
            //Affichage du form Question/Reponse pour le test 2 car c'est le seul a utiliser des séries 
                TestEnCours.CompteurSerie++;
                AttentionTest testencours = (AttentionTest)(TestEnCours);
                if (TestEnCours.CompteurSerie == 1)
                {
                    Test2QuestionForm QR = new Test2QuestionForm(testencours,Regle);
                    QR.Show();
                }
                else
                {
                        Test2QuestionForm QR = new Test2QuestionForm(testencours, Score, Regle);
                        QR.Show();
                }

            this.Hide();
        }

        private void Serie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
