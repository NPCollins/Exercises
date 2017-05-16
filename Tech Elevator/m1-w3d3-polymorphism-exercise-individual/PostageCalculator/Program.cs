using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string weightUnit = "";
            bool correctInput = true;
            
            do
            {
                Console.WriteLine("Pounds or ounces?");
                weightUnit = Console.ReadLine().ToLower();
                if (weightUnit.ToLower() == "pounds" || weightUnit.ToLower() == "ounces")
                {
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Use (pounds) or (ounces).");
                    correctInput = false;
                }
            }
            while (correctInput == false);

            Console.WriteLine($"How many {weightUnit}?");
            string weightString = Console.ReadLine();
            double weightDouble = double.Parse(weightString);
            if (weightUnit == "pounds")
            {
                weightDouble *= 16;
            }

            Console.WriteLine("How many miles will you be shipping your package?");
            string distanceString = Console.ReadLine();
            int distanceInt = int.Parse(distanceString);


            List<IDeliveryDriver> possibiltyList = new List<IDeliveryDriver>();
            SPU fdSPU = new SPU();
            fdSPU.ShippingType = "fd";
            SPU tdSPU = new SPU();
            tdSPU.ShippingType = "td";
            SPU ndSPU = new SPU();
            ndSPU.ShippingType = "nd";
            FexEd deliveryFexEd = new FexEd();
            PostalServiceFirst serviceFirst = new PostalServiceFirst();
            PostalServiceSecond serviceSecond = new PostalServiceSecond();
            PostalServiceThird serviceThird = new PostalServiceThird();

            Dictionary<IDeliveryDriver, double> possibilityDictionary = new Dictionary<IDeliveryDriver, double>();
            possibilityDictionary.Add(fdSPU,fdSPU.CalculateRate(distanceInt, weightDouble));
            possibilityDictionary.Add(tdSPU, tdSPU.CalculateRate(distanceInt, weightDouble));
            possibilityDictionary.Add(ndSPU, ndSPU.CalculateRate(distanceInt, weightDouble));
            possibilityDictionary.Add(deliveryFexEd, deliveryFexEd.CalculateRate(distanceInt, weightDouble));
            possibilityDictionary.Add(serviceFirst, serviceFirst.CalculateRate(distanceInt, weightDouble));
            possibilityDictionary.Add(serviceSecond, serviceSecond.CalculateRate(distanceInt, weightDouble));
            possibilityDictionary.Add(serviceThird, serviceThird.CalculateRate(distanceInt, weightDouble));



            Console.Write("Deliver Method".PadRight(35));
            Console.WriteLine("$ cost");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Postal Service (1st Class)".PadRight(35));
            Console.WriteLine($"${possibilityDictionary[serviceFirst]}");
            Console.Write("Postal Service (2nd Class)".PadRight(35));
            Console.WriteLine($"${possibilityDictionary[serviceSecond]}");
            Console.Write("Postal Service (3rd Class)".PadRight(35));
            Console.WriteLine($"${possibilityDictionary[serviceThird]}");
            Console.Write("FexEd".PadRight(35));
            Console.WriteLine($"${possibilityDictionary[deliveryFexEd]}");
            Console.Write("SPU (4-day ground)".PadRight(35));
            Console.WriteLine($"${possibilityDictionary[fdSPU]}");
            Console.Write("SPU (2-day business)".PadRight(35));
            Console.WriteLine($"${possibilityDictionary[tdSPU]}");
            Console.Write("SPU (next-day)".PadRight(35));
            Console.WriteLine($"${possibilityDictionary[ndSPU]}");

        }
    }
}
