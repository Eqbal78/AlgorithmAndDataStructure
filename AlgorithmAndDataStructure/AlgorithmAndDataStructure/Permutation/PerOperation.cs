using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructure.Permutation
{
    class PerOperation
    {
        public static void permu()
        {
            Console.WriteLine("\nThis is Permutation Problem\n");
            Console.WriteLine("Enter a string to permute : ");
            string str = Console.ReadLine();
            Console.WriteLine("\nPermutation Combinations is:");
            int startPos = 0, endPos = str.Length - 1;
            Permutation.Permute(str, startPos, endPos);
            Console.WriteLine("-----------------------------------\n");
        }
    }
}
