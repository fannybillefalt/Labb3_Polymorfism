using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorfism
{
    internal class Square : Geometry
    {
        public double Base { get; set; }

        public Square()
        {
            Base = 10;
        }
        public override double AreaMethod()
        {
            return Base * Base;            
        }
    }
}
