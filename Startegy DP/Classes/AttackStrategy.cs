using Startegy_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy_DP.Classes
{
    internal class AttackStrategy : IStrategy
    {
        public void Play()
        {
            Console.WriteLine("Team With Attack Strategy");
        }
    }
}
