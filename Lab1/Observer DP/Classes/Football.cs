using Lab1.Observer_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Observer_DP.Classes
{
    internal class Football:IBall
    {
        public List<IObserver> Observers { get; set; }
        private Position _ballPosition;
        public Position MyPosition
        {
            get => _ballPosition;
            set
            {
                _ballPosition = value;
                NotifyObservers();
            }
        }
        public Football()
        {
            _ballPosition = new Position();
            Observers = new List<IObserver>();
        }
     
        public void AttachObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void DetachObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(_ballPosition);
            }
        }
    }
}
