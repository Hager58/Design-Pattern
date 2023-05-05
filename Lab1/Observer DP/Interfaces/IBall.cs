using Lab1.Observer_DP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Observer_DP.Interfaces
{
    internal interface IBall
    {   
        public void AttachObserver(IObserver observer);
        public void DetachObserver(IObserver observer);
        public void NotifyObservers();

    }
}
