using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApS2.Modele
{
    [Table("Produit")]
    public class Produit
    {
        #region Attributs
        public static List<Produit> collClass = new List<Produit>();
        private int _id;
        private string _nom;
        private string _photo;
        private int _prixreel;

      
        #endregion

        #region Constructeurs 
        public Produit(int id, string nom, string photo, int prixreel)
        {
            _id = id;
            _nom = nom;
            _photo = photo;
            _prixreel = prixreel;
            collClass.Add(this);
        }


        #endregion

        #region Getters/Setters  
        public static List<Produit> Produits { get => collClass; set => collClass = value; }
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Photo { get => _photo; set => _photo = value; }
        public int Prixreel { get => _prixreel; set => _prixreel = value; }

        #endregion

        #region Méthodes

        #endregion
      

     
    }
}