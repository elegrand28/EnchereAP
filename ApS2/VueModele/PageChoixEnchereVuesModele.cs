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
    public class PageChoixEnchereVuesModele :BaseVueModele
    {
        private readonly Api _apiServices = new Api();

        

        private ObservableCollection<Enchere> _enchereList;

        public ObservableCollection<Enchere> EnchereList
        {
            get { return _enchereList; }
            set { SetProperty(ref _enchereList, value); }
        }


        public PageChoixEnchereVuesModele()
        {
            Init();

        }

        public async Task<ObservableCollection<Enchere>>GetEnchereEnCoursId(int id)
        {
            var x =await _apiServices.GetAllAsyncID("api/getEncheresEnCours", Enchere.collClass, "Id", id);
            Enchere.collClass.Clear();
            return x;
        }
        public async Task<ObservableCollection<Enchere>> GetEnchereEnCours()
        {
            var x = await _apiServices.GetAllAsync("api/getEncheresEnCours", Enchere.collClass);
            Enchere.collClass.Clear();
            return x;
        }
        public async void Init ()
        {
            EnchereList = await GetEnchereEnCours();
            
        }


    }
}
