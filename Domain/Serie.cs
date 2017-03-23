using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml; 
using System.Xml.Serialization; 

namespace Domain
{
    public class Serie
    {
        private int id = 0;
        public Test MonTest { get; set; }
        public QuestionRep[] TabQuestion { get; set; } //va contenir les questions choisies pour cette série utilie pour les QCM tests
        public int CompteurQ { get; set; }
        public string EnonceSerie { get; set; }

        public Serie(Test Untest)
        {
            id++;
            MonTest = Untest;
            
            CompteurQ = 0;

            //On mélange le tableau de toutes les questions contenu dans la classe QCMTest
            if (MonTest is QCMTest)
            {
                TabQuestion = new QuestionRep[MonTest.NbQparSerie];
                Melanger(MonTest.Questions);
                //On va sélectionner les 10 premières questions pour implémenter TabQuestion
                for (int i = 0; i < MonTest.NbQparSerie; i++)
                    TabQuestion[i] = MonTest.Questions[i];
            }
        }


        public static void Melanger(QuestionRep[] tab)
        {
            Random rand = new Random();

            for (int i = 0; i < tab.Length - 1; i++)
            {
                int j = rand.Next(i, tab.Length);
                QuestionRep temp = tab[i];
                tab[i] = tab[j];
                tab[j] = temp;
            }
        }

    }
}
