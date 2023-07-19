using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class Person
    {
        public string Name { get; set; }

        public DateTime Dob { get; set; } //Containment - a complex type used as a prop for another complex type

        public string FavColor { get; set; }


        public override string ToString()
        {
            //base.ToString() refers to the Parent class' ToString method
            //return base.ToString();

            return $"I am {Name}. I was born on {Dob:d}. My favorite color is {FavColor}.";
        }
    }
}
