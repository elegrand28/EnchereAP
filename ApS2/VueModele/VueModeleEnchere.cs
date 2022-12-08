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
    public class VueModeleEnchere :BaseVueModele
    {
        private Enchere _laEnchere;
        private readonly Api _apiServices = new Api();
        private ObservableCollection<Encherir> _listEncherir;

        public Enchere LaEnchere { get => _laEnchere; set => SetProperty(ref _laEnchere, value); }
        public ObservableCollection<Encherir> ListEncherir { get => _listEncherir; set => SetProperty(ref _listEncherir, value); }

        public VueModeleEnchere(Enchere laenchere)
        {
            LaEnchere= laenchere;
            Init();

        }


        public async Task<ObservableCollection<Encherir>> GetLastOffer(int id)
        {
            var x = await _apiServices.GetAllAsyncID("api/getLastSixOffer", Encherir.collClass, "Id", id);
            Encherir.collClass.Clear();
            return x;

        }
        public async void Init ()
        {
            ListEncherir = await GetLastOffer(LaEnchere.Id);
        }

    }
}
