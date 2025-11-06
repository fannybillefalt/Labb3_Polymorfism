using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorfism
{
    internal class Circle : Geometry
    {   
        private double _pi = 3.14159;
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 5;
        }
        public override double AreaMethod()
        {
            return Radius * Radius * _pi;
        }
    }
}
