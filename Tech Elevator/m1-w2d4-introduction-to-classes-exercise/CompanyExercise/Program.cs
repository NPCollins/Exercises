using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechElevator.Classes;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * These first three exercises do not provide tests. They idea behind providing it 
            * within a Console application is to allow you to see how to instantiate and interact
            * with classes that you define as part of the exercise.
            * 
            * It is intentionally left open ended so that you can modify your class and then
            * see how the changes allow you to interact with it differently. 
            *
            * Go slow and note how the intellisense suggestions change based on the modifications you make
            * to the class file
            */

            // Instantiate a new company
            // e.g. Company variableName = new Company();
            Company newCompany = new Company();
            // Try Setting the name of the Company
            // e.g. variableName.PropertyName = value
            newCompany.CompanyName = "The Scooter Factory";
            // Try Getting the name of the Company
            // e.g. Console.WriteLine(variableName.PropertyName)
            // e.g. string name = variableName.PropertyName;
            Console.WriteLine(newCompany.CompanyName);
            // Try setting some of the other Company properties
            newCompany.CompanyPurpose = "Provide fancy scooters to those who can afford them.";
            // If you implemented CompanySize as a calculated property are you able
            // to set the value or do you receive a compile error?
            // I get a compile error, the property is read only.
            // Does CompanySize and Profit return the correct value based on the other properties?
            Console.WriteLine(newCompany.CompanyIsSuccessful);
            // Try instantiating another company object and doing the same as above with it
        }
    }
}
