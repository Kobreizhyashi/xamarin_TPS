using System;
namespace TpModule4.Entities
{
    public class Tweet
    {
        // identifiant, date de création,texte, nom de l’utilisateur, identifiant de l’utilisateur et pseudo de l’utilisateur.
       
        public String Date { get; set; }
        public String Content { get; set; }
        public User User { get; set; }

        public Tweet()
        {
        }
    }
}
