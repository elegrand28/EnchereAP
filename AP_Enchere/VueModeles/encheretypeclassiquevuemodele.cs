using AP_Enchere.Services;
using AP_Enchere.VueModeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_Enchere.VueModele
{
    public class encheretypeclassiquevuemodele : BaseVueModele
    {
        #region attributs  
        private DecompteTimer tmps;
        private int _tempsRestantJour;
        private int _tempsRestantHeures;
        private int _tempsRestantMinutes;
        private int _tempsRestantSecondes;

        public bool OnCancel = false;
        #endregion
        #region Constructeurs
        public encheretypeclassiquevuemodele()
        {

            tmps = new DecompteTimer();
            DateTime datefin = new DateTime(2022, 12, 13);
            TimeSpan interval = datefin - DateTime.Now;
            tmps.Start(interval);


            this.GetTimerRemaining();

        }
        #endregion
        #region Getters/Setters



        public int TempsRestantHeures
        {
            get { return _tempsRestantHeures; }
            set { SetProperty(ref _tempsRestantHeures, value); }
        }
        public int TempsRestantJour
        {
            get { return _tempsRestantJour; }
            set { SetProperty(ref _tempsRestantJour, value); }
        }
        public int TempsRestantMinutes
        {
            get { return _tempsRestantMinutes; }
            set { SetProperty(ref _tempsRestantMinutes, value); }
        }
        public int TempsRestantSecondes
        {
            get { return _tempsRestantSecondes; }
            set { SetProperty(ref _tempsRestantSecondes, value); }
        }
        #endregion
        #region methodes
        public void GetTimerRemaining()
        {

            Task.Run(() =>
            {

                while (OnCancel == false)
                {
                    TempsRestantJour = tmps.TempsRestant.Days;
                    TempsRestantHeures = tmps.TempsRestant.Hours;
                    TempsRestantMinutes = tmps.TempsRestant.Minutes;
                    TempsRestantSecondes = tmps.TempsRestant.Seconds;

                    if (tmps.TempsRestant <= TimeSpan.Zero)
                    {
                        OnCancel = true;
                    }
                }

            });


        }

        #endregion
    }
}
        
    


