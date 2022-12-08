using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApS2.Modele
{
    public class Encherir
    {

        #region Attributs
        public  static List<Encherir> collClass = new List<Encherir>();
        private User _leUser;
        private Enchere _laEnchere;
        private float _prixEnchere;
        private DateTime dateenchere;
        private string _pseudo;



        #endregion

        #region Constructeurs
        public Encherir(User leUser, Enchere laEnchere, float prixEnchere, string pseudo)
        {
            _leUser = leUser;
            _laEnchere = laEnchere;
            _prixEnchere = prixEnchere;
            CollClass.Add(this);
            _pseudo = pseudo;
        }


        #endregion

        #region Getters/Setters
        public static List<Encherir> CollClass { get => collClass; set => collClass = value; }
        public User LeUser { get => _leUser; set => _leUser = value; }
        public Enchere LaEnchere { get => _laEnchere; set => _laEnchere = value; }
        public float PrixEnchere { get => _prixEnchere; set => _prixEnchere = value; }
        public DateTime Dateenchere { get => dateenchere; set => dateenchere = value; }
        public string Pseudo { get => _pseudo; set => _pseudo = value; }
        public int IdUser { get => _leUser.Id; }
        public int IdEnchere { get => _laEnchere.Id; }


        #endregion

        #region Méthodes

        #endregion

    }
}

       
    