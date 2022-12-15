using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApS2.Modele
{
    [Table("Enchere")]
    public class Enchere
    {

        #region Attributs
        public static List<Enchere> collClass = new List<Enchere>();
        private int _id;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private int _prixReserve;
        private int _prixDeDepart;
        private Produit _leProduit;
        private TypeEnchere _typeEnchere;
        private Magasin _leMagasin;

        #endregion

        #region Constructeurs
        public Enchere(int id, DateTime dateDebut, DateTime dateFin, int prixReserve, int prixDeDepart,
                              Produit leProduit, TypeEnchere typeEnchere, Magasin leMagasin)
        {
            _id = id;
            _dateDebut = dateDebut;
            _dateFin = dateFin;
            _prixReserve = prixReserve;
            _prixDeDepart = prixDeDepart;
            _leProduit = leProduit;
            _typeEnchere = typeEnchere;
            _leMagasin = leMagasin;
            collClass.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey, AutoIncrement]
        public int Id { get => _id; set => _id = value; }
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public int PrixReserve { get => _prixReserve; set => _prixReserve = value; }
        public int PrixDepart { get => _prixDeDepart; set => _prixDeDepart = value; }
        public Produit Leproduit { get => _leProduit; set => _leProduit = value; }
        public Magasin LeMagasin { get => _leMagasin; set => _leMagasin = value; }
        public TypeEnchere TypeEnchere { get => _typeEnchere; set => _typeEnchere = value; }

        #endregion

        #region Méthodes

        #endregion
    }
}



