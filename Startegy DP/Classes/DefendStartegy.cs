using Startegy_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy_DP.Classes
{
    internal class DefendStartegy:IStrategy
    {
        public void Play()
        {
            Console.WriteLine("Team With Defend Strategy");
        }
    }
}
