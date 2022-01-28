using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlockVisualiser.Boids
{
    public class TestBoid
    {

        public int XPos { get; set; }
        public int YPos { get; set; }

        public string ImageSource { get { return "/AssemblyName;component/Boids/Icons/Boid.png"; }  }

        public double Angle { get; set; }

    }
}
