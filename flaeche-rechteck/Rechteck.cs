using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_flaeche_rechteck
{
    class Rechteck
    {
        public double Height { get; set; }
        public double Width { get; set; }


        public double GetArea()
        {
            return Height * Width;
        }
    }
}
