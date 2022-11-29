using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ApS2.Modele
{
    [Table("User")]
    public class User
    {


        #region Attributs
        public static List<User> collClass = new List<User>();
        private string _pseudo;
        public string _photo;
        public string _password;
        public string _email;

        public static User UtilisateurConnecté;
        #endregion

        #region Constructeurs
        public User(int id, string pseudo, string photo, string password, string email)
        {
            Id = id;
            Pseudo = pseudo;
            Photo = photo;
            Password = password;
            Email = email;
            collClass.Add(this);
        }


        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Pseudo { get { return _pseudo; } set { _pseudo = value; } }
        public string Photo { get { return _photo; } set { _photo = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string Email { get { return _email; } set { _email = value; } }


        #endregion

        #region Méthodes

        #endregion


    }
}