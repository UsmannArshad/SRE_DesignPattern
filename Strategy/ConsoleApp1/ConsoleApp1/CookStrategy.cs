using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// The Strategy abstract class, which defines an interface common to all supported strategy algorithms.
    /// </summary>
    interface CookStrategy
    {
        void cook(string a);
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class Grilling : CookStrategy
    {
        public void cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class OvenBaking : CookStrategy
    {
        public  void cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by oven baking it.");
        }
    }

    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class DeepFrying : CookStrategy
    {
        public void cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it");
        }
    }

    /// <summary>
    /// The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    class CookingMethod
    {
        private string Food;
        private CookStrategy _cookStrategy;

        public void SetCookStrategy(CookStrategy cookStrategy)
        {
            _cookStrategy = cookStrategy;
        }

        public void SetFood(string name)
        {
            Food = name;
        }

        public void Cook()
        {
            _cookStrategy.cook(Food);
            Console.WriteLine();
        }
    }
}