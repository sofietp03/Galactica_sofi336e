using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_sofi336e
{
    enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }
    internal class Star : SpaceObjects
    {


        public Startype Type { get; set; }
        int Temperatur { get; set; }

       public List<Planet>? PlanetList { get; set; }

        public override Position? Pos { get; set; } = new Position() { X = 0, Y = 0 };

    }

}
