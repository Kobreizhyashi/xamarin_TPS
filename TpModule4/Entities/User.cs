using System;
namespace TpModule4.Entities     
{
    public class User
    {
        public int Id { get; set; }
        public String Pseudo { get; set; }
        public String Name { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }

        public User(int userId, string userPseudo, string userName, string login, string password)
        {
            Id = userId;
            Pseudo = userPseudo;
            Name = userName;
            Login = login;
            Password = password;
        }
    }
}
