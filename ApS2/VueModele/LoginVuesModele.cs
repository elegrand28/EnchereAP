using ApS2.Modele;
using ApS2.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApS2.VueModele
{
    public class LoginVueModele : BaseVueModele
    {
        #region Attributs
        private readonly Api _apiServices = new Api();

        private ObservableCollection<User> _maListe;
        private User _user;

        #endregion

        #region Constructeurs

        public LoginVueModele()
        {

            //this.PostUser(new User(0, "esssssai01", "tititiddddtit","pseudo","ddd"));w
        }

        #endregion

        #region Getters/Setters
        public ObservableCollection<User> MaListe
        {
            get { return _maListe; }
            set { SetProperty(ref _maListe, value); }

        }

        public User LeUser
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }
        #endregion

        #region Methodes

        public async void PostUser(User param)
        {
            int x = await _apiServices.PostAsync(param, "api/postUser");

        }



        public async Task<User> GetUserByUsernameAndPass(string Username, string Password)
        {
            LeUser = new User(0, "", "", Password, Username);
            LeUser= await _apiServices.GetOneAsync<User>("api/getUserByMailAndPass", new User(0, "", "", Password, Username));
            await SecureStorage.Default.SetAsync("session", "" + LeUser.Id);
            return LeUser;

        }


       
        #endregion
    }
}