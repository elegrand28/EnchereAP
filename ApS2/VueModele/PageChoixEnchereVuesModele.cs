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

        
            
    
         
        


    }
}
