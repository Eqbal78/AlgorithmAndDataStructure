using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructure.AnagramDetection
{
    class Anagram
    {
        /// <summary>
        /// Bool method to check string is anagram or not
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>
        public bool areAnagram(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return false;
            }
            //Convert string to character array  
            char[] firstCharsArray = firstString.ToLower().ToCharArray();
            char[] secondCharsArray = secondString.ToLower().ToCharArray();
            //Sort array  
            Array.Sort(firstCharsArray);
            Array.Sort(secondCharsArray);
            //Check each character and position.  
            for (int i = 0; i < firstCharsArray.Length; i++)
            {
                if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
                {
                    return false;
                }
            }
            return true;
        }

        public static void AngInput()
        {
            Console.WriteLine("\nThis is Angram Programme");
            string firstString, secondString;

            //Gets words from user.  
            Console.WriteLine("\nEnter first string");
            firstString = Console.ReadLine();
            Console.WriteLine("\nEnter second string");
            secondString = Console.ReadLine();

            Anagram anagram = new Anagram();

            //Check if words are anagram  
            if (anagram.areAnagram(firstString, secondString) == true)
            {
                Console.WriteLine("\nBoth string are anagram string.");
            }
            else
            {
                Console.WriteLine("\nBoth string are not anagram string.");
            }
            Console.WriteLine("\n----------------------------------------------\n");
        }
    }
}
