using AP_Enchere.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AP_Enchere.Interfaces
{
    interface IDecompteTimer
    {
        void Start(TimeSpan CountdownTime);
        void Stop();

        event EventHandler<TimerEventArgs> TicTac;
        event EventHandler Complet;
        event EventHandler Avorte;
    }
}