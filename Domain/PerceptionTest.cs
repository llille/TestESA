using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class PerceptionTest : Test
    {
        public PerceptionTest(bool niveauDifficulte)
            : base(niveauDifficulte)
        {
            NomTest="Perception et mémoire associative";
            Ennonce= "A chaque question, 12 figures de formes et de couleurs différentes vont apparaitre sur l'application."
                +"\nIl faudra retenir les nombres dans les formes demandées par la question."
                +"\n\nRemarque : Les réponses peuvent être données dans n'importe quel ordre.";
            Exemple = "Question : \nRetenez les chiffres écrits dans les rectangles jaunes."
                +"\n\nLes bonnes réponses sont : 7, 9 et 1.";              
            NbSerie=1;
            NbQparSerie = 10;
            CompteurSerie = 0;

            //Création du test
            id++;
                //création de la variable difficulté du test
            DifficulteTest = new Difficulte(niveauDifficulte);
            DifficulteTest.TempsReponse = 0; //pas de limite de temps
                    //si le niveau = facile
            if (niveauDifficulte)
            {
                DifficulteTest.RegleDifficulte = "Les figures s'affichent 4 secondes.";
                DifficulteTest.TempsAffichageQ = 4;
            }
                    //si le niveau = difficile
            else
            {
                DifficulteTest.RegleDifficulte = "Les figures s'affichent 2 secondes.";
                DifficulteTest.TempsAffichageQ = 2;
            }

            //Création des séries
            TabSerie = new Serie[NbQparSerie];
        }
    }
}
