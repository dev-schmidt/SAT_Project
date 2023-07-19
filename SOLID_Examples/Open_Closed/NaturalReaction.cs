using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class NaturalReaction
    {
        //public static void Noise(Dog[] dogs)
        //{
        //    foreach (Dog pupper in dogs)
        //    {
        //        Console.WriteLine("Bork");
        //    }
        //}

        //        public static void Noise(Object[] animals)
        //        {
        //            foreach (Object pet in animals)
        //            {
        //        if (pet.GetType().Name == "Dog")
        //        {
        //            Console.WriteLine("Bark");
        //        }

        //        else if (pet.GetType().Name == "Cat")
        //        {
        //            Console.WriteLine("Meow");
        //        }
        //    }
        //}

        public static void Noise(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Sound());
            }
        }
    }
}
