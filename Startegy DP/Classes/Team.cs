using Startegy_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startegy_DP.Classes
{
    internal class Team
    {
        public IStrategy TeamStrategy { set; get; }
        public Team(IStrategy strategy)
        {
            TeamStrategy = strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            TeamStrategy = strategy;
        }
        public void PlayGame()
        {
            TeamStrategy.Play();
        }
    }

}
