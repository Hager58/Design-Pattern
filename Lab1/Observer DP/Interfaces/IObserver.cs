using Lab1.Observer_DP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Observer_DP.Interfaces
{
    internal interface IObserver
    {
        public void Update(Position position);
    }
}
