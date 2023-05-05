
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Observer_DP.Classes
{
    internal class Position
    {
        public Position()
        {

        }
        public Position(int x, int y, int z)
        {
            X = x; Y = y; Z = z;
        }        
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }    
    }
}
