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
        public double CurrentAngle { get; set; } = 0;

        public void Rotate(double rotationAngle)
        {
            CurrentAngle += rotationAngle;
            CurrentAngle = TransformAngle(CurrentAngle);
        }

        private double TransformAngle(double angle)
        {
            while (angle > 180)
            {
                angle = angle - 360;
            }
            // and vice versa
            while (angle < -179)
            {
                angle = angle + 360;
            }

            return angle;
        }

    }
}
