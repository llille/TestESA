using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization; 

namespace Domain
{
    public abstract class Test
    {
        protected static int id = 0;
        public static List<string[]> Scores=new List<string[]>();  //va contenir les scores des tests de l'utilisateur (historique)
        public string NomTest { get; set; }
        public string Ennonce { get; set; }
        public string Exemple { get; set; }
        public int NbSerie { get; set; }
        public int NbQparSerie { get; set; }

        public Serie[] TabSerie { get; set; }
        public int CompteurSerie { get; set; }

        public Difficulte DifficulteTest { get; set; }

        public QuestionRep[] Questions { get; set; } //va contenir toutes les questions du fichier désérialisé

        public Test(bool niveaudiff)
        {
        }

        public void Deserialisation(string filePath) //filePath : Chemin d'accès au fichier de connexion sur le disque
        {
            if (File.Exists(filePath))
            {
                XmlSerializer xs = new XmlSerializer(typeof(QuestionRep[]));
                using (StreamReader rd = new StreamReader(filePath))
                {
                    this.Questions = xs.Deserialize(rd) as QuestionRep[];
                }
            }
        }
        
    }
}
