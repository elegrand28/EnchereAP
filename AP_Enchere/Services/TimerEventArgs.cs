using System;

namespace AP_Enchere.Services
{
    public class TimerEventArgs : EventArgs
    {
        public TimeSpan TempsRestant { get; set; }

    }

}
