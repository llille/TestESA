using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Difficulte
    {
        public enum NiveauDifficulte {Facile=1,Difficile};

        public NiveauDifficulte NivDifficulteTest { get; set; }
        public string RegleDifficulte { get; set; }
        public int TempsAffichageQ { get; set; }
        public int TempsReponse { get; set; }

        public Difficulte(bool nivDiff)
        {
            if (nivDiff== true)
                NivDifficulteTest = NiveauDifficulte.Facile;
            else
                NivDifficulteTest = NiveauDifficulte.Difficile;
        }
    }
}
