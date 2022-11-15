using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APre.Modeles
{
    public class Encherir
    { 

        #region Attributs
        public static List<Encherir> collClass = new List<Encherir>();
        private User _leUser;
        private Enchère _laEnchere;
        private int _prixEnchere;
        private DateTime dateenchere;




        #endregion

        #region Constructeurs
        public Encherir(User leUser, Enchère laEnchere, int prixEnchere, DateTime dateenchere)
        {
            _leUser = leUser;
            _laEnchere = laEnchere;
            _prixEnchere = prixEnchere;
            this.dateenchere = dateenchere;

            #endregion

            #region Getters/Setters

            #endregion

            #region Méthodes

            #endregion

        }
    }
}
