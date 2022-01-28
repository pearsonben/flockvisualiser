using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlockVisualiser.Boids
{
    public class BoidBase : IBoidBase
    {

        public Point CurrentPosition { get; set; }
        public double CurrentAngle { get; set; } = 0;

        public void MoveX(int increment)
        {
            
        }

        public void MoveY(int increment)
        {

        }

        public void Rotate(double rotationAngle)
        {
            CurrentAngle += rotationAngle;
            CurrentAngle = TransformAngle(CurrentAngle);
        }


        public double TransformAngle(double angle)
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
