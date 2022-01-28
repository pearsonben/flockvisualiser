using System.Drawing;

namespace FlockVisualiser.Boids
{
    public interface IBoidBase
    {
        double CurrentAngle { get; set; }
        Point CurrentPosition { get; set; }

        void MoveX(int increment);
        void MoveY(int increment);

        void Rotate(double rotationAngle);
        double TransformAngle(double angle);
    }
}