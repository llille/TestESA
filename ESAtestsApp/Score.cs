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
    public partial class ScoreForm : Form
    {

        public ScoreForm()
        {
            InitializeComponent();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            //Affichage du form Menu Principal
            MenuForm Menu = new MenuForm();
            Menu.Show();
            this.Hide();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
        }

        private void TestListB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int BestScoreF = 0; //meilleur score des tests d'une catégorie (niveau facile)
            int BestScoreD = 0; //meilleur score des tests d'une catégorie (niveau difficile)
            int ScoreMoyF = 0; //score moyen des tests d'une catégorie (niveau facile)
            int cptF = 0; //nombre de fois que le test a été effectué (niveau facile)
            int ScoreMoyD = 0; //score moyen des tests d'une catégorie (niveau difficile)
            int cptD = 0;  //nombre de fois que le test a été effectué (niveau difficile)

            List<string[]> ScoresTests=Test.Scores; //on copie dans une autre variable pour ne pas modifier directement Scores
                                                     //Chaque élément (tableau de string) de ScoresTests={nom du test, difficulté, score}

            if (TestListB.SelectedItem != null) //permet de vérifier que l'utilisateur a sélectionné une catégorie
            {
                string TChoisi = (string)TestListB.SelectedItem;

                //Méthode pour les 5 tests :
                //On va parcourir la liste contenant les scores de tous les tests (variable ScoresTests) en cherchant lesquels correspondent à TChoisi          
                    //On va "sélectionner" le test que l'on souhaite avec la première ligne de l'élément k de ScoresTests
                    //On va "sélectionner" la difficulté que l'on souhaite avec la deuxième ligne de l'élément k de ScoresTests
                        //On va ajouter à ScoreMoy (F ou D) le score
                        //On va comparer à BestScore (F ou D) le score
                        //On va ajouter 1 au compteur de tests effectués (pour pouvoir à la fin le diviser à ScoreMoy)

                #region Test 1

                if (TChoisi=="Perception et mémoire associative") 
                {
                    foreach (string[] tab in ScoresTests)
                    {
                        if (tab[0] == "Perception et mémoire associative")
                        {
                            if (tab[1] == "Facile")
                            {
                                ScoreMoyF += int.Parse(tab[2]);
                                if (int.Parse(tab[2]) > BestScoreF)
                                    BestScoreF = int.Parse(tab[2]);
                                cptF++;
                            }
                            else
                            {
                                ScoreMoyD += int.Parse(tab[2]);
                                if (int.Parse(tab[2]) > BestScoreD)
                                    BestScoreD = int.Parse(tab[2]);
                                cptD++;
                            }
                        }
                    }
                }
                #endregion

                #region Test 2
                if (TChoisi == "Attention et concentration")
                {
                    foreach (string[] tab in ScoresTests)
                    {
                        if (tab[0] == "Attention et concentration")
                        {
                            if (tab[1] == "Facile")
                            {
                                ScoreMoyF += int.Parse(tab[2]);
                                if (int.Parse(tab[2]) > BestScoreF)
                                    BestScoreF = int.Parse(tab[2]);
                                cptF++;
                            }
                            else
                            {
                                ScoreMoyD += int.Parse(tab[2]);
                                if (int.Parse(tab[2]) > BestScoreD)
                                    BestScoreD = int.Parse(tab[2]);
                                cptD++;
                            }
                        }
                    }
                }
                #endregion

                #region Test 3
                if (TChoisi == "Calcul mental")
                {
                    foreach (string[] tab in ScoresTests)
                    {
                        if (tab[0] == "Calcul mental")
                        {
                            if (tab[1] == "Facile")
                            {
                                ScoreMoyF += int.Parse(tab[2]);
                                if (int.Parse(tab[2]) > BestScoreF)
                                    BestScoreF = int.Parse(tab[2]);
                                cptF++;
                            }
                            else
                            {
                                ScoreMoyD += int.Parse(tab[2]);
                                if (int.Parse(tab[2]) > BestScoreD)
                                    BestScoreD = int.Parse(tab[2]);
                                cptD++;
                            }
                        }
                    }
                }
                #endregion

                #region Test 4
                if (TChoisi == "Problèmes mathématiques")
                {
                    foreach (string[] tab in ScoresTests)
                    {
                        if (tab[0] == "Problèmes mathématiques")
                        {
                            if (tab[1] == "Facile")
                            {
                                ScoreMoyF += int.Parse(tab[2]);
                                if (int.Parse(tab[2]) > BestScoreF)
                                    BestScoreF = int.Parse(tab[2]);
                                cptF++;
                            }
                            else
                            {
                                ScoreMoyD += int.Parse(tab[2]);
                                if (int.Parse(tab[2]) > BestScoreD)
                                    BestScoreD = int.Parse(tab[2]);
                                cptD++;
                            }
                        }
                    }
                }
                #endregion

                #region Test 5
                if (TChoisi == "Problèmes physiques")
                {
                    foreach (string[] tab in ScoresTests)
                    {
                        if (tab[0] == "Problèmes physiques")
                        {
                           if (tab[1] == "Facile")
                            {
                                ScoreMoyF+=int.Parse(tab[2]);
                                if (int.Parse(tab[2]) > BestScoreF)
                                    BestScoreF = int.Parse(tab[2]);
                                cptF++;
                            }
                            else
                            {
                                ScoreMoyD += int.Parse(tab[2]);
                                if (int.Parse(tab[2]) > BestScoreD)
                                    BestScoreD = int.Parse(tab[2]);
                                cptD++;
                            }
                        }
                    }
                }
                #endregion

                //si il y a déjà des lignes, on les supprime
                if (ScoresDataGV.Rows.Count != 0)
                    ScoresDataGV.Rows.Clear();

                //On ajoute les 2 lignes de scores
                if (cptF!=0)
                    this.ScoresDataGV.Rows.Add("Facile", BestScoreF + "%", ScoreMoyF / cptF + "%");
                else
                    this.ScoresDataGV.Rows.Add("Facile", "None", "None");

                if (cptD!=0)
                    this.ScoresDataGV.Rows.Add("Difficile", BestScoreD + "%", ScoreMoyD / cptD + "%");
                else
                    this.ScoresDataGV.Rows.Add("Difficile", "None", "None");
             
            }
        }

        private void Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
