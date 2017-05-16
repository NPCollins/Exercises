using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ExerciseProblems
{
    public class Exercises
    {
        /*
	    * Dictionary/Dictionary Exercises
	    */

        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").  
         * 
         * The animal name should be case insensitive so "elephant", "Elephant", and 
         * "ELEPHANT" should all return "herd". 
         * 
         * If the name of the animal is not found, null, or empty, return "unknown". 
         * 
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * animalGroupName("giraffe") → "Tower"
         * animalGroupName("") -> "unknown"         
         * animalGroupName("walrus") -> "unknown"
         * animalGroupName("Rhino") -> "Crash"
         * animalGroupName("rhino") -> "Crash"
         * animalGroupName("elephants") -> "unknown"
         * 
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> animalDictionary = new Dictionary<string, string>();
            animalDictionary.Add("rhino", "Crash");
            animalDictionary.Add("giraffe", "Tower");
            animalDictionary.Add("elephant", "Herd");
            animalDictionary.Add("lion", "Pride");
            animalDictionary.Add("crow", "Murder");
            animalDictionary.Add("pigeon", "Kit");
            animalDictionary.Add("flamingo", "Pat");
            animalDictionary.Add("deer", "Herd");
            animalDictionary.Add("dog", "Pack");
            animalDictionary.Add("crocodile", "Float");

            if (animalDictionary.ContainsKey(animalName.ToLower()))
            {
                return animalDictionary[animalName.ToLower()];
            }
            else
            {
                return "unknown";
            }

        }

        /*
         * Given an string item number (a.k.a. SKU), return the discount percentage if the item is on sale.
         * If the item is not on sale, return 0.00.
         * 
         * If the item number is empty or null, return 0.00.
         * 
         * "KITCHEN4001" -> 0.20
         * "GARAGE1070" -> 0.15
         * "LIVINGROOM"	-> 0.10
         * "KITCHEN6073" -> 0.40
         * "BEDROOM3434" -> 0.60
         * "BATH0073" -> 0.15
         * 
         * The item number should be case insensitive so "kitchen4001", "Kitchen4001", and "KITCHEN4001"
         * should all return 0.20.
         *  
         * isItOnSale("kitchen4001") → 0.20
         * isItOnSale("") → 0.00
         * isItOnSale("GARAGE1070") → 0.15
         * isItOnSale("dungeon9999") → 0.00 
         * 
         */
        public double IsItOnSale(string itemNumber)
        {
            Dictionary<string, double> itemDictionary = new Dictionary<string, double>();
            itemDictionary.Add("KITCHEN4001", 0.20);
            itemDictionary.Add("GARAGE1070", 0.15);
            itemDictionary.Add("LIVINGROOM", 0.10);
            itemDictionary.Add("KITCHEN6073", 0.40);
            itemDictionary.Add("BEDROOM3434", 0.60);
            itemDictionary.Add("BATH0073", 0.15);

            if (itemDictionary.ContainsKey(itemNumber.ToUpper()))
            {
                return itemDictionary[itemNumber.ToUpper()];
            }
            else
            {
                return 0.00;
            }
        }

        /*
         * Modify and return the given Dictionary as follows: if "Peter" has more than 0 money, transfer half of it to "Paul",
         * but only if Paul has less than $10s.
         * 
         * Note, monetary amounts are specified in cents: penny=1, nickel=5, ... $1=100, ... $10=1000, ...
         * 
         * robPeterToPayPaul({"Peter": 2000, "Paul": 99}) → {"Peter": 1000, "Paul": 1099}
         * robPeterToPayPaul({"Peter": 2000, "Paul": 30000}) → {"Peter": 2000, "Paul": 30000}
         * 
         */
        public Dictionary<string, int> RobPeterToPayPaul(Dictionary<string, int> peterPaul)
        {
            return null;
        }

        /*
         * Modify and return the given Dictionary as follows: if "Peter" has $50 or more, AND "Paul" has $100 or more,
         * then create a new "PeterPaulPartnership" worth a combined contribution of a quarter of each partner's
         * current worth.
         * 
         * peterPaulPartnership({"Peter": 50000, "Paul": 100000}) → {"Peter": 37500, "Paul": 75000, "PeterPaulPartnership": 37500}
         * peterPaulPartnership({"Peter": 3333, "Paul": 1234567890}) → {"Peter": 3333, "Paul": 1234567890}
         * 
         */
        public Dictionary<string, int> PeterPaulPartnership(Dictionary<string, int> peterPaul)
        {
            return null;
        }

        /*
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array, 
         * there is a key of its first character with the value of its last character.
         *
         * beginningAndEnding(["code", "bug"]) → {"b": "g", "c": "e"}
         * beginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * beginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d", "m": "t", "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
            Dictionary<string, string> firstLast = new Dictionary<string, string>();
            for (int i = 0; i < words.Length; i++)
            {
                firstLast[words[i].Substring(0, 1)] = words[i].Substring(words[i].Length - 1, 1);
            }
            return firstLast;
        }
        /*
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the 
         * number of times that string appears in the array.
         * 
         * ** A CLASSIC **
         * 
         * wordCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * wordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * wordCount([]) → {}
         * wordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         * 
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            Dictionary<string, int> wordCountDictionary = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordCountDictionary.ContainsKey(word))
                {
                    wordCountDictionary[word] += 1;
                }
                else
                {
                    wordCountDictionary[word] = 1;
                }
            }
            return wordCountDictionary;
        }

        /*
         * Given an array of int values, return a Dictionary<int, int> with a key for each int, with the value the 
         * number of times that int appears in the array.
         * 
         * ** The lesser known cousin of the the classic wordCount **
         * 
         * intCount([1, 99, 63, 1, 55, 77, 63, 99, 63, 44]) → {1: 2, 44: 1, 55: 1, 63: 3, 77: 1, 99:2}
         * intCount([107, 33, 107, 33, 33, 33, 106, 107]) → {33: 4, 106: 1, 107: 3}
         * intCount([]) → {}
         * 
         */
        public Dictionary<int, int> IntCount(int[] ints)
        {
            Dictionary<int, int> numberCountDictionary = new Dictionary<int, int>();
            foreach (int number in ints)
            {
                if (numberCountDictionary.ContainsKey(number))
                {
                    numberCountDictionary[number] += 1;
                }
                else
                {
                    numberCountDictionary[number] = 1;
                }
            }
            return numberCountDictionary;
        }

        /*
         * Given an array of strings, return a Dictionary<string, Boolean> where each different string is a key and value
         * is true only if that string appears 2 or more times in the array.
         * 
         * wordMultiple(["a", "b", "a", "c", "b"]) → {"b": true, "c": false, "a": true}
         * wordMultiple(["c", "b", "a"]) → {"b": false, "c": false, "a": false}
         * wordMultiple(["c", "c", "c", "c"]) → {"c": true}
         * 
         */
        public Dictionary<string, bool> WordMultiple(string[] words)
        {
            Dictionary<string, int> wordCountDictionary = new Dictionary<string, int>();
            Dictionary<string, bool> wordBoolDictionary = new Dictionary<string, bool>();
            foreach (string word in words)
            {
                if (wordCountDictionary.ContainsKey(word))
                {
                    wordCountDictionary[word] += 1;
                }
                else
                {
                    wordCountDictionary[word] = 1;
                }
            }
// Can probably call on the int count class here because the above code is a copy
            foreach (KeyValuePair<string, int> kvp in wordCountDictionary)
            {
                if (kvp.Value >= 2)
                {
                    wordBoolDictionary[kvp.Key] = true;
                } 
                else
                {
                    wordBoolDictionary[kvp.Key] = false;
                }
            }
            return wordBoolDictionary;
        }

        /*
         * Given two Dictionarys, Dictionary<string, int>, merge the two into a new Dictionary, Dictionary<string, int> where keys in Dictionary2, 
         * and their int values, are added to the int values of matching keys in Dictionary1. Return the new Dictionary.
         * 
         * Unmatched keys and their int values in Dictionary2 are simply added to Dictionary1.
         *  
         * consolidateInventory({"SKU1": 100, "SKU2": 53, "SKU3": 44} {"SKU2":11, "SKU4": 5})
         * 	 → {"SKU1": 100, "SKU2": 64, "SKU3": 44, "SKU4": 5}
         * 
         */
        public Dictionary<string, int> ConsolidateInventory(Dictionary<string, int> mainWarehouse, 
            Dictionary<string, int> remoteWarehouse)
        {
            Dictionary<string, int> mainWarehouseCache = mainWarehouse;
            Dictionary<string, int> remoteWarehouseCache = remoteWarehouse;
            Dictionary<string, int> consolidationDictionary = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> kvp in mainWarehouseCache)
            {
                consolidationDictionary[kvp.Key] = kvp.Value;
            }
            foreach (KeyValuePair<string, int> kvp in remoteWarehouseCache)
            {
                if (consolidationDictionary.ContainsKey(kvp.Key))
                {
                    consolidationDictionary[kvp.Key] += kvp.Value;
                }
                else
                {
                    consolidationDictionary[kvp.Key] = kvp.Value;
                }
            }
            return consolidationDictionary;
        }

        /*
         * Just when you thought it was safe to get back in the water --- last2Revisited!!!!
         * 
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears 
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1. 
         * 
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.  
         * 
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *  
         * last2Revisited(["hixxhi", "xaxxaxaxx", "axxxaaxx"]) → {"hixxhi": 1, "xaxxaxaxx": 1, "axxxaaxx": 2}
         * 
         */
        public Dictionary<string, int> Last2Revisted(string[] words)
        {
            return null;
        }

    }
}
