using ApS2.Modele;
using ApS2.Services;
using ApS2.Vue;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApS2.VueModele
{
    public class PageChoixEnchereVuesModele : BaseVueModele
    {
        private readonly Api _apiServices = new Api();



        private ObservableCollection<Enchere> _enchereList;
        private ObservableCollection<Enchere> _enchereListClassique;
        private ObservableCollection<Encherir> _encherirList;
        public static User LeUser;

       public ObservableCollection<Encherir> EncherirList
        {
            get { return _encherirList; }
            set { SetProperty(ref _encherirList,value);}
        }

        public ObservableCollection<Enchere> EnchereList
        {
            get { return _enchereList; }
            set { SetProperty(ref _enchereList, value); }
        }
        public ObservableCollection<Enchere> EnchereClassiqueList
        {
            get { return _enchereListClassique; }
            set{  SetProperty(ref _enchereListClassique, value);}
            
        }
        



        public PageChoixEnchereVuesModele()
        {
            GetUser();
            Init();
        }

        public async Task<ObservableCollection<Enchere>> GetEnchereTypeEnCours(int letype)
        {
            var x = await _apiServices.GetAllAsyncID("api/getEncheresEnCours", Enchere.collClass, "IdTypeEnchere", letype);
            Enchere.collClass.Clear();
            return x;
        }
        public async Task<ObservableCollection<Enchere>> GetEnchereEnCours()
        {
            var x = await _apiServices.GetAllAsync("api/getEncheresEnCours", Enchere.collClass);
            Enchere.collClass.Clear();
            return x;
        }
        public async void Init()
        {
            EnchereClassiqueList = await GetEnchereTypeEnCours(1);
           
           
            

        }

        public async void PostEnchereClassique(float param, Enchere current )
        {
             var x = await _apiServices.PostAsync<Encherir>(new Encherir(LeUser, current, param, LeUser.Pseudo), "api/postEncherir");
           
           
        }
        public async void GetUser()
        {
            string x = await SecureStorage.Default.GetAsync("session");

            if (x != null)
            {
                LeUser = await _apiServices.GetOneAsyncID<User>
                    ("api/getUser", x);
                Enchere.collClass.Clear();
            
            }
        }

      

       








    }
}
