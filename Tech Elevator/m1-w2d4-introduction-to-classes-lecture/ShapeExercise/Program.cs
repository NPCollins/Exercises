using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Add a using statement
using ShapeExercise.Classes;

namespace ShapeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Instantiating our class
            Rectangle r1 = new Rectangle();

            //2. Setting the value of properties
            r1.Width = 3;
            r1.Height = 4;

            //3. Getting the value of properties
            Console.WriteLine("The rectangles width is " + r1.Width);
            Console.WriteLine("The rectangles height is " + r1.Height);
            Console.WriteLine();

            //4. Getting the area
            Console.WriteLine("R1s Area is " + r1.CalculateArea());

            //---------AGAIN
            //1. Instantiate the class
            Rectangle r2 = new Rectangle();

            //2. Setting value of properties
            r2.Width = 5;
            r2.Height = 9;

            //3. Getting the value of properties
            Console.WriteLine("The rectangles width is " + r2.Width);
            Console.WriteLine("The rectangles height is " + r2.Height);
            Console.WriteLine();

            //4. Getting the area
            Console.WriteLine("R2s Area is " + r2.CalculateArea());


        }
    }
}
