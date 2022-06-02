using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{
    public class ParticleType
    {
        private string name;
        private string color;
        private string otherParticleData;
        public ParticleType(string name, string color, string otherParticleData)
        {
            this.name = name;
            this.color = color;
            this.otherParticleData = otherParticleData;
        }
        public void DrawParticle(int x, int y)
        {
            Console.WriteLine(this.ToString() + " is located currently at (" + x + ", " + y + ")");
        }
        public override string ToString()
        {
            return $"Particle Type [name = " + name + ", color = " + color + ", Other particle data = " + otherParticleData + "]";

        }
    }
}
