using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_sofi336e
{

    public class Position
    {

        public int X { get; }
        int y;
        public override string  ToString()
        {

            return $"({X},{y})";
        }
    }
}

