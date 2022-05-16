using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_sofi336e
{
    internal class Star : SpaceObjects
    {


        public Startype  startype {get; set;}
        int Temperatur { get; set; }

        List<string> Planet { get; set; }

        public string Sun { get; set; }
        
    }
    enum PlaneType {Terrestial,Giant,Dwarf,Gas_Giant}


}
