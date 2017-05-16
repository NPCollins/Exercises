using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            int lineCounter = 0;
            int instanceCounter = 0;
            string currentLine;

            Console.WriteLine("Input the directory:");
            string directory = Console.ReadLine();
            Console.WriteLine("Input the file name:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Input the word you want to search for:");
            string wordToFind = Console.ReadLine();
            Console.WriteLine("Do you want the search to be case sensitive? (y/n)");
            string caseSensitiveString = Console.ReadLine().ToLower();
            bool caseSensitive;
            if (caseSensitiveString == "y")
            {
                caseSensitive = true;
            }
            else
            {
                caseSensitive = false;
            }
            string file = Path.Combine(directory, fileName);

            StreamReader fullPath = new StreamReader(file);
            while ((currentLine = fullPath.ReadLine()) != null)
            {
                if (caseSensitive)
                {
                    if (currentLine.Contains(wordToFind))
                        {
                            Console.WriteLine(lineCounter.ToString() + ": " + currentLine);
                            instanceCounter++;
                        }
                }
                else
                {
                    if (currentLine.Contains(wordToFind.ToLower()))
                    {
                        Console.WriteLine(lineCounter.ToString() + ": " + currentLine);
                        instanceCounter++;
                    }
                }
                

                lineCounter++;
            }

            fullPath.Close();
            Console.WriteLine(instanceCounter);

        }
    }
}
