using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_sofi336e
{
    internal sealed class Moon : Planet
    {
        public Planet? Orbiting { get; set; }

        public double? Distance(Planet planet)
        {
            if (Pos != null && planet.Pos != null)
                return
             Math.Sqrt((Pos.X - planet.Pos.X) ^ 2 + (Pos.Y - planet.Pos.Y) ^ 2);
            else return null;
        }

    }
}
