using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization; 

namespace Domain
{
    public class QCMTest : Test
    {
        public string Matiere { get; set; }

        public QCMTest(bool niveauDifficulte, string matiere)
            : base(niveauDifficulte)
        {
            NomTest="Problèmes "+matiere;
            if (matiere == "mathématiques")
            {
                Ennonce = "Le test de type QCM présente 1 série de 10 problèmes mathématiques. Vous avez le choix entre 4 réponses.";
                Exemple = "Question : \nHors saison, un hôtel propose une chambre double à 80 euros. En pleine saison, le prix augmente de 15%. "
                    +"\nQuel est le prix de la chambre double en pleine saison?"
                    +"\n\nBonne réponse : 92";
            }
            else
            {
                Ennonce = "Le test de type QCM présente 1 série de 10 problèmes de physique, chimie ou technologie. Vous avez le choix entre 4 réponses.";
                Exemple = "Question : \nLa vitesse de balayage de l’oscilloscope est B=1ms/div. La sensibilité verticale de l’oscilloscope est Sv=2 V/div."
                    +"Combien de temps dure une période?"
                    +"\n\nBonne réponse : 4 ms";
            }
            NbSerie = 1;
            NbQparSerie = 10;
            CompteurSerie = 0;

            id++;
            Matiere = matiere;

                //création de la variable difficulté du test
            DifficulteTest = new Difficulte(niveauDifficulte);
            DifficulteTest.TempsAffichageQ = 0; //pas de limite de temps
            DifficulteTest.TempsReponse = 0; //pas de limite de temps
                    //si le niveau = facile
            if (niveauDifficulte)
                DifficulteTest.RegleDifficulte = "Les questions sont de niveau facile";     
                    //si le niveau = difficile
            else
                DifficulteTest.RegleDifficulte = "Les questions sont de niveau difficile";

            //Création du tableau des questions
            CreationQuestions(); 

            //Création des séries
            TabSerie = new Serie[NbSerie];
            //création/insertion de chaque série dans le tab
            for (int i = 0; i < NbSerie; i++)
            {
                TabSerie[i] = new Serie(this);
            }
        }

        public void CreationQuestions()
        {
            //Recherche du bon fichier à désérialiser
            string filePath = "";
            if (Matiere == "mathématiques")
            {
                if (DifficulteTest.NivDifficulteTest == Difficulte.NiveauDifficulte.Facile)
                    filePath = @"../../../Ressources/MathQuestionFacile.xml";
                else
                    filePath = @"../../../Ressources/MathQuestionDifficile.xml";
            }

            else
            {
                if (DifficulteTest.NivDifficulteTest == Difficulte.NiveauDifficulte.Facile)
                    filePath = @"../../../Ressources/PhyQuestionFacile.xml";
                else
                    filePath = @"../../../Ressources/PhyQuestionDifficile.xml";
            }

            //Désérialisation du fichier
            Deserialisation(filePath);

        }

    }
}
