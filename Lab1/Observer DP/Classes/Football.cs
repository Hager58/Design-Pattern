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
      
        private readonly List<IObserver> _subscribers;

        public FootBall()
        {
            MyPosition = new Position();
            _subscribers = new List<IObserver>();
        }
        public List<IObserver> Observers { get; set; }
        public Position MyPosition {
            get => MyPosition; 
            set
            {
                MyPosition = value;
                NotifyObservers();
            }
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
            foreach (var subscriber in Observers)
            {
                subscriber.Update(MyPosition);
            }
        }
    }
}
