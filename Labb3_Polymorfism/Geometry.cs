using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorfism
{
    public abstract class Geometry
    {
        public double Radius { get; set; }
        public abstract double AreaMethod();
        
    }
}
