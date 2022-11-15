using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APre.Modeles
{
    [table("magasin")]
    public class Magasin
    {
       

       
        #region Attributs
        private static List<Magasin> collClass = new List<Magasin>();
        private int _id;
        private string _nom;
        private string _adresse;
        private string _ville;
        private string _codePostal;
        private int _portable;
        private double _latitude;
        private double _longitude;




        #endregion

        #region Constructeurs
        public Magasin(int id, string nom, string adresse, string ville,
            string codePostal, int portable, double latitude, double longitude)
        {
            _id = id;
            _nom = nom;
            _adresse = adresse;
            _ville = ville;
            _codePostal = codePostal;
            _portable = portable;
            _latitude = latitude;
            _longitude = longitude;
            collClass.Add(this);
        }

        #endregion

        #region Getters/Setters
        [PrimaryKey,AutoIncrement]
        public static List<Magasin> CollClass { get => collClass; set => collClass = value; }
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Adresse { get => _adresse; set => _adresse = value; }
        public String Ville { get => _ville; set => _ville = value; }
        public String CodePostal { get => _codePostal; set => _codePostal = value; }
        public Int Portable { get => _portable; set => _portable = value; }
        public Double Latitude { get => _latitude; set => _latitude = value; }
        public Double Longitude { get => _longitude; set => _longitude = value; }

        [OneToMany(typeof(Enchère))]
        public 


        #endregion

        #region Méthodes

        #endregion


    }
}
