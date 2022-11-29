using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApS2.Modele
{
    public class TypeEnchere
    {
        #region Attributs
        private static List<TypeEnchere> collClass = new List<TypeEnchere>();
        private int _id;
        private string _nom;

      




        #endregion

        #region Constructeurs 
        public TypeEnchere(int id, string nom)
        {
            _id = id;
            _nom = nom;
            collClass.Add(this);
        }

        #endregion

        #region Getters/Setters
        public static List<TypeEnchere> CollClass { get => collClass; set => collClass = value; }
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }

        #endregion

        #region Méthodes

        #endregion




    }
}