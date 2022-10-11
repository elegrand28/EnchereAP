
using APre.Modeles;
using APre.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APre
{
    public class UserVueModele : BaseVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();

        private ObservableCollection<User> _maListe;

        #endregion

        #region Constructeurs

        public UserVueModele()
        {
            this.TestBase();
            //this.PostUser(new User(0, "esssssai01", "tititiddddtit","pseudo","ddd"));
        }

        #endregion

        #region Getters/Setters
        public ObservableCollection<User> MaListe
        {
            get { return _maListe ; }
            set { SetProperty(ref _maListe, value); }
        }
        #endregion

        #region Methodes

        public async void PostUser(User param)
        {
            int x = await _apiServices.PostAsync<User>(param, "api/postUser");

        }
        public async void TestBase()
        {
            User leUser = new User();
           
            leUser.id = 0;
            leUser.pseudo = "Ricardo";
            leUser.password = "toto";
 


           
          
        }
        #endregion
    }
}
