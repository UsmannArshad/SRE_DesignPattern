using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// In computer programming, the strategy pattern is a behavioral software design pattern that enables selecting an algorithm at runtime.
    /// Instead of implementing a single algorithm directly, code receives run-time instructions as to which in a family of algorithms to use.
    /// In this example, we want to cook some food using a variety of different methods.
    /// In a naive example, we'd need an IF statement for each cooking method.
    /// If we have a lot of cooking methods, we'll also have a lot of IF statements.
    /// But in this example, we can define a Strategy for each cook method and simply set which one we want at runtime.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            CookingMethod cookMethod = new CookingMethod();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            cookMethod.SetFood(food);

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            Console.WriteLine("1)Grilling");
            Console.WriteLine("2)Oven Baking");
            Console.WriteLine("3)Deep Frying");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());


            switch (input)
            {
                case 1:
                    cookMethod.SetCookStrategy(new Grilling());
                    cookMethod.Cook();
                    break;

                case 2:
                    cookMethod.SetCookStrategy(new OvenBaking());
                    cookMethod.Cook();
                    break;

                case 3:
                    cookMethod.SetCookStrategy(new DeepFrying());
                    cookMethod.Cook();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
