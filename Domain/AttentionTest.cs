using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class AttentionTest : Test
    {
        public AttentionTest(bool niveauDifficulte)
            : base(niveauDifficulte) 
        {
            NomTest="Attention et concentration";
            Ennonce= "Différentes figures vont s'afficher une à une. Il faudra retenir les points communs entre les figures successives."
                +"\n\nA chaque affichage de figure, vous aurez le choix entre trois boutons. Chaque bouton est associé à une règle donnée."
                +"\nA chaque fois, il faudra cliquer sur le bouton explicitant la règle commune entre la figure affichée et la précédente.";
            Exemple = "Règles : \nbutt1 -> Même nombre de points"+
                "\nbutt2 -> Même forme"+
                "\nbutt3 -> Dans tous les autres cas"+
                "\n\n Bonne réponse : \n1er écran : butt3 (par défaut) \n2e écran : butt1 \n3e écran : butt3";
            NbSerie=3;
            NbQparSerie = 5;
            CompteurSerie = 0;

            //Création du test
            id++;

                //création de la variable difficulté du test
            DifficulteTest = new Difficulte(niveauDifficulte);
            DifficulteTest.TempsAffichageQ = 0; //pas de limite de temps, mais ok/erreur s'affiche 3 sec

            if (niveauDifficulte)
            {
                DifficulteTest.RegleDifficulte = "Il n'y a pas de limite de temps pour répondre";     
                DifficulteTest.TempsReponse = 0; //pas de limite de temps
            }
            else
            {
                DifficulteTest.TempsReponse = 5; 
                DifficulteTest.RegleDifficulte = "Vous avez " + DifficulteTest.TempsReponse.ToString() +" secondes pour répondre";
                
            }

            TabSerie = new Serie[NbQparSerie];
        }
    }
}
