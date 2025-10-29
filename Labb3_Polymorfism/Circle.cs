using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3_Polymorfism
{
    internal class Circle : Geometry
    {
        
        public float Radius { get; set; }
        public float Circumference { get; set; }

        public Circle()
        {
            Radius = 5;
            Circumference = 6;
        }
        public override float AreaMethod()
        {
            float circleArea = Radius * Radius * _pi;
            return circleArea;
        }
    }
}
