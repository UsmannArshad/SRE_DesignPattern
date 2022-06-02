namespace Flyweight_Design_Pattern
{
    public class Demo
    {
        static Random rnd = new Random();
        static int plotSize = 500;
        static int particlesToDraw = 1000;
        static int particlesTypes = 2;
        public static void Main(string[] args)
        {
            Game game = new Game();
            for (int i = 0; i < Math.Floor(Convert.ToDecimal(particlesToDraw / particlesTypes)); i++)
            {
                game.DrawParticle(rnd.Next(0, plotSize), rnd.Next(0, plotSize), "Bullet", "Silver", "Rifle Bullet");
                game.DrawParticle(rnd.Next(0, plotSize), rnd.Next(0, plotSize), "Missile", "Green", "Shaheen");
            }
            game.DisplayParticles();
            Console.WriteLine("Particles to draw: " + particlesToDraw);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("*******Memory usage*******");
            Console.WriteLine("Particle size (8 bytes) * " + particlesToDraw);
            Console.WriteLine("Particle type size (~30 bytes) * " + particlesTypes + "");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Total: " + ((particlesToDraw * 8 + particlesTypes * 30) / 1024) + "KB (instead of) " + ((particlesToDraw * 38) / 1024) + "KB)");
        }
    }
}