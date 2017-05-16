using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechElevator.Classes;

namespace DogExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new TechElevator.Classes.Dog();
            myDog.Sleep();
            Console.WriteLine(myDog.MakeSound());
        }
    }
}
