using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{
    public class Game
    {
        private List<MovingParticle> particles = new List<MovingParticle>();
        public void DrawParticle(int x, int y, string name, string color, string otherParticleData)
        {
            ParticleType type = ParticleFactory.GetParticleType(name, color, otherParticleData);
            MovingParticle particle = new MovingParticle(x,y,type);
            particles.Add(particle);
        }
        public void DisplayParticles()
        {
            foreach(MovingParticle p in particles)
            {
                p.DrawParticle();
            }
        }
    }
}
