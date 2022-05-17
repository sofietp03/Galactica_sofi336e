using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_sofi336e
{
    enum PlaneType {Rocky, Terrestial, Giant, Dwarf, Gas_Giant }
    internal class Planet:SpaceObjects
    {
        public PlaneType Type { get; set; }
        public int Diameter { get; set; }

        public int RotationPerios { get; set; }

        public int RevolutionPeriod { get; set; }

         public List <Moon>? MoonList { get; set; }

        public double? Distance ()
        {
            if (Pos != null) return 
                    Math.Sqrt((Math.Abs(Pos.X) ^ 2) + (Math.Abs(Pos.Y) ^ 2));
            else return null;
        }

    }
    

}
