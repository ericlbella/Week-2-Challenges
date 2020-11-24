using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Challenges
{
    class Greeter
    {
        public void Name(string name)
        {
            //String Interpolation
            Console.WriteLine($"Hello {name}");

            // Acess modifer
            // return type
            //Method Signature = Method Name and any parameters that I want the method to take
        }

        public void Farewell(string name)
        {
            // String Interlotation
            Console.WriteLine($"Farewell {name}");
        }
        ///
        public void TimeOfDay()
        {
            // Depending on the current time, print either Good Morning, Good Afternoon, Good Evening, or Good Night
            DateTime time = new DateTime();

            // get the current time
            time = DateTime.Now;

            // if it is past midnnight but before noon, print "Good morning."
            if (time.Hour >= 0 && time.Hour < 12)
            {
                Console.WriteLine("Good morning.");
            }

            // if it past noon but before 6PM, print "Good afternoon."
            else if (time.Hour >= 12 && time.Hour < 17)
            {
                Console.WriteLine("Good afternoon");
            }
            // if it is past 6PM but before 9PM, print "Good evening."
            else if (time.Hour >= 17 && time.Hour <= 21)
            {
                Console.WriteLine("Good evening.");
            }
            else
            {
                Console.WriteLine("Good night.");
            }

        }
    }
}
