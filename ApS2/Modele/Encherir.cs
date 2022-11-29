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
        private int _prixEnchere;
        private DateTime dateenchere;




        #endregion

        #region Constructeurs
        public Encherir(User leUser, Enchere laEnchere, int prixEnchere, DateTime dateenchere)
        {
            LeUser = leUser;
            LaEnchere = laEnchere;
            PrixEnchere = prixEnchere;
            this.Dateenchere = dateenchere;
            CollClass.Add(this);
        }


        #endregion

        #region Getters/Setters
        public static List<Encherir> CollClass { get => collClass; set => collClass = value; }
        public User LeUser { get => _leUser; set => _leUser = value; }
        public Enchere LaEnchere { get => _laEnchere; set => _laEnchere = value; }
        public int PrixEnchere { get => _prixEnchere; set => _prixEnchere = value; }
        public DateTime Dateenchere { get => dateenchere; set => dateenchere = value; }

        #endregion

        #region Méthodes

        #endregion

    }
}

       
    