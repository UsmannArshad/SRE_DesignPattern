namespace ChainOfResponsibility_Design_Pattern
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            DispenserChain chain = new DispenserChain();
            chain.Dispense(new Currency(1600));
        }
    }
}
