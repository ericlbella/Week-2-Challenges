using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();

            string name;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            greeter.Name(name);
            greeter.Farewell(name);
            greeter.TimeOfDay();

            Console.ReadKey();
        }
    }
}
