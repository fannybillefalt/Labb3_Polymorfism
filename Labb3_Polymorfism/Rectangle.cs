using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorfism
{
    internal class Rectangle : Geometry
    {
        public double Height { get; set; }
        public double Lenght { get; set; }

        public Rectangle()
        {
            Height = 5;
            Lenght = 10;
        }

        public override double AreaMethod()
        {
            return Height * Lenght;
        }
    }
}
