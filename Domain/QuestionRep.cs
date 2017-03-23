using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization; 

namespace Domain
{
    public class QuestionRep
    {
        public string EnnonceTexte { get; set; }
        public string Image { get; set; }
        public string[] TabReponses { get; set; }
        public string BonneRep { get; set; }


        public QuestionRep()
        {
        }

    }
}
