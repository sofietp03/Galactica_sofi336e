using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_sofi336e
{
    internal class Planet:SpaceObjects
    {
        public int Diameter { get; set; }

        public int RotationPerios { get; set; }

        public int RevolutionPeriod { get; set; }

        List <string> Moon { get; set; }

    }

   
}
