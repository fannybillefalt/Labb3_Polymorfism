using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorfism
{
    internal class Geometry
    {
        public float _pi = 3.141f;
        public double Area { get; set; }
        public float Radius { get; set; }
        public float Volume { get; set; }
        public float Circumference { get; set; }
        public virtual float AreaMethod()
        {
            float circleArea = Radius * Radius * _pi;
            return circleArea;
        }
    }
}
