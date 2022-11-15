using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions.Attributes;

namespace APre.Modeles
{
    [Table("encherir")]
    public class Encherir
    {
        
        #region Attributs
        private static List<Encherir> collClass = new List<Encherir>();
        private User _leUser;
        private Enchère _laEnchere;
        private int _prixEnchere;
        private DateTime dateenchere;




        #endregion

        #region Constructeurs
        public Encherir(User leUser, Enchère laEnchere, int prixEnchere, DateTime dateenchere)
        {
            LeUser = leUser;
            LaEnchere = laEnchere;
            PrixEnchere = prixEnchere;
            this.Dateenchere = dateenchere;
            CollClass.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public static List<Encherir> CollClass { get => collClass; set => collClass = value; }
        public User LeUser { get => _leUser; set => _leUser = value; }
        public Enchère LaEnchere { get => _laEnchere; set => _laEnchere = value; }
        public int PrixEnchere { get => _prixEnchere; set => _prixEnchere = value; }
        public DateTime Dateenchere { get => dateenchere; set => dateenchere = value; }

        [ForeignKey(nameof(LeUser))]
        public int UserId { get; set; }

        [ForeignKey(nameof(LaEnchere))]
        public int EnchereId { get; set; }

        [OneToOne(typeof(User))]
        public List<User> LesUsers { get; set; }

        [OneToMany(typeof(Enchère))]
        public List<Enchère> LesEncheres { get; set; }



            #endregion

            #region Méthodes

            #endregion

        }

        
    }
}
