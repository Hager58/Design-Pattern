using Lab1.Observer_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Observer_DP.Classes
{
    internal class Player:IObserver
    {
        public Position BallPosition { get; set; }
        public Player()
        {
            BallPosition = new Position();
        }
        public void Update(Position position)
        {
            BallPosition = position;

            Console.WriteLine("Player is updated");
        }
    }
}
