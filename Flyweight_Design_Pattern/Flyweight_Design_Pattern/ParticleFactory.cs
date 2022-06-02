using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{
    internal class ParticleFactory
    {
        private static Dictionary<string, ParticleType> ParticleTypes = new Dictionary<string, ParticleType>();
        public static ParticleType GetParticleType(string name, string color, string otherParticleData)
        {
            ParticleType? result = null;
            if (ParticleTypes.TryGetValue(name, out result))
            {

            }
            else
            {
                result = new ParticleType(name, color, otherParticleData);
                ParticleTypes.Add(name, result);
            }
            return result;

        }
    }
}
