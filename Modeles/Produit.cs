using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APre.Modeles
{
    public class Produit
    {
        public static List<Produit> produits = new List<Produit>();
        private int _id;
        private string _nom;
        private string _photo;
        private int _prixreel;
    }
}
