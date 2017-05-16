using Lecture.Farming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /* You cannot create an instance of an interface type */

            //IFarmAnimal animal = new IFarmAnimal();  // this causes a compiler error



            /* A child-type instance may be assigned to a parent-type reference.
             * In this case, a Cow "is-a" IFarmAnimal since Cow and Chicken implements IFarmAnimal.  
             * Therefore, we can assign a new instance of Cow or Chicken to a reference 
             * variable of type IFarmAnimal */
            IFarmAnimal aFarmAnimal = new Cow();
            IFarmAnimal aSecondFarmAnimal = new Chicken();




            /* When we call interface methods, it is actually the implementing 
             * class's methods that get invoked. */
            string animalName = aFarmAnimal.NameOfAnimal; // invokes Cow.getName()
            string sound = aFarmAnimal.MakeSoundOnce(); // invokes Cow.getSound()
            Console.WriteLine(animalName + " says " + sound);

            animalName = aSecondFarmAnimal.NameOfAnimal; // invokes Cow.getName()
            sound = aSecondFarmAnimal.MakeSoundOnce(); // invokes Cow.getSound()
            Console.WriteLine(animalName + " says " + sound);


            /* Classes that implement an interface can also define other methods 
             * that are not part of the interface. */
            Chicken aChicken = new Chicken();
            aChicken.LayEgg();  // layEgg is not defined as part of the IFarmAnimal interface




            /* If a child-type instance is referred to using a parent-type reference, only 
             * methods of the parent-type are available */
            IFarmAnimal genericAnimal = aChicken;  // assigning a Chicken reference to a variable of parent-type Animal
            
            //genericAnimal.LayEgg();   //this causes a compiler error because genericAnimal is a
                                        //reference of type IFarmAnimal and LayEgg() is not a method of type Animal












            //
            // OLD MACDONALD
            //

            //Applying Polymorphism, we're allowed to work in terms of 
            // interfaces and not concrete class types. In this case
            // the list holds a collection of IFarmAnimal, meaning
            // any class that implements the IFarmAnimal interface is allowed 
            // to be in the list.

            List<IFarmAnimal> oldMacDonaldsArmy = new List<IFarmAnimal>();

            //Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            //for(int i = 0; i < oldMacDonaldsArmy.Count; i++)
            //{
            //    Console.WriteLine("And on his farm there was a " + oldMacDonaldsArmy[i].NameOfAnimal + " ee ay ee ay oh");
            //    Console.WriteLine("With a " + oldMacDonaldsArmy[i].MakeSoundTwice() + " here and a " + oldMacDonaldsArmy[i].MakeSoundTwice() + " there");
            //    Console.WriteLine("Here a " + oldMacDonaldsArmy[i].MakeSoundOnce() + ", there a " + oldMacDonaldsArmy[i].MakeSoundOnce() + " everywhere a " + oldMacDonaldsArmy[i].MakeSoundTwice());
            //    Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            //    Console.WriteLine();
            //}





        }
    }
}
