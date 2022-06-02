using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{
    public class MovingParticle
    {
        private readonly int x;
        private readonly int y;
        private readonly ParticleType type;
        public MovingParticle(int x, int y, ParticleType type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }
        public void DrawParticle()
        {
            type.DrawParticle(x, y);
        }
    }
}
