using System;
namespace TpModule4.Models
{
    public class Tweet
    {
        // identifiant, date de création,texte, nom de l’utilisateur, identifiant de l’utilisateur et pseudo de l’utilisateur.
        public String Login { get; set; }
        public String Date { get; set; }
        public String Name { get; set; }
        public String Content { get; set; }
        public String Pseudo { get; set; }

        public Tweet()
        {
        }
    }
}
