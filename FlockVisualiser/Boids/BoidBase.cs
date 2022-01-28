using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlockVisualiser.Boids
{
    public class BoidBase
    {

        public Point CurrentPosition { get; set; }
        public double CurrentAngle { get; set; } = 90;

        public void Rotate(double angle)
        {
            CurrentAngle += angle;
        }

    }
}
