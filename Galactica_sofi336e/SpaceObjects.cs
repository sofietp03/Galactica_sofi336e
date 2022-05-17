using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_sofi336e
{
    internal abstract class SpaceObjects
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual Position? Pos { get; set; }

        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }

        }

        public override string? ToString()
        {
            if(Pos!= null) return $"({Pos.X},{Pos.Y})";
            else return string.Empty;
        }
    }
    
}
