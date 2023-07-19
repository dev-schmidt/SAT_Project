using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    internal class Actions
    {
        public static void Intro(Person person)
        {
            Console.WriteLine($"{person.ToString()}");
        }

        //Liskov Substitution: Any parent class object should be replaceable with a
        //child class object and maintain the same behavior without modification.

        //Example that violates the Liskov Substitution Principle:
        //public static void Intro(Person person)
        //{
        //    Console.WriteLine($"I am {person.Name}. I was born on {person.Dob:d}. My favorite color is {person.FavColor}.");

        //    if (DateTime.Now.Year - person.Dob.Year >= 16)
        //    {
        //        Console.WriteLine("I do have my driver's license.");
        //    }

            //The behavior above requires modification for a conditional check
            //to determine whether or not we need to output driver's license info.
        }
    }
}
