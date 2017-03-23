using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class CalculTest : Test
    {


        public CalculTest(bool niveauDifficulte)
            : base(niveauDifficulte)
        {
            NomTest = "Calcul mental";
            Ennonce = "Vous allez devoir choisir une opération (addition, soustraction, multiplication, division) et réaliser de tête les calculs qui vous seront proposés."
                + "\n Vous devrez réaliser 10 calculs. \n\nRemarque : Pour la division, il s'agit de division entière, il faut arrondir au plus proche.";
            Exemple = "Pour l'opération : 168/7 \nBonne réponse : 24.";
            NbSerie = 1;
            NbQparSerie = 10;
            CompteurSerie = 0;


            id++;
            //création de la variable difficulté du test
            DifficulteTest = new Difficulte(niveauDifficulte);
            DifficulteTest.TempsAffichageQ = 0; //pas de limite de temps
            //si le niveau = facile
            if (niveauDifficulte)
            {
                DifficulteTest.RegleDifficulte = "Il n'y a pas de limite de temps pour répondre";
                DifficulteTest.TempsReponse = 0; //pas de limite de temps
            }
            //si le niveau = difficile
            else
            {
                DifficulteTest.TempsReponse = 5;
                DifficulteTest.RegleDifficulte = "Vous avez "+ DifficulteTest.TempsReponse.ToString() +" secondes pour répondre à chaque question.";
                
            }

            //Création des séries
            Serie serie = new Serie(this);
            TabSerie = new Serie[NbSerie];
            TabSerie[0] = serie;
            serie.EnonceSerie = "Choisissez une opération et réalisez les 10 calculs de tête";

        }
    }
}
