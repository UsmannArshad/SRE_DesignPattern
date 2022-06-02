using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give Username:");
            string username=Console.ReadLine();
            Console.WriteLine("Give Password:");
            string pwd = Console.ReadLine();
            DataBaseExecuterProxy db = new DataBaseExecuterProxy(username,pwd);
            db.ExecuteDataBase("Select from user");
        }
    }
}
