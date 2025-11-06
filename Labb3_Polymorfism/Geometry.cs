using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorfism
{
    //Using abstact because I will not create an object from this class,
    //only sub-classes.
    public abstract class Geometry
    {
        public double Radius { get; set; }

        //Since this method doesn't need to do anything in this class,
        //I made it abstract and override it in the subclasses.
        public abstract double AreaMethod();
        
    }
}
