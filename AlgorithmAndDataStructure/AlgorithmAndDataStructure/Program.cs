using System;


namespace AlgorithmAndDataStructure.Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Permutation Problem");
            Console.WriteLine("Enter a string to permute : ");
            string str = Console.ReadLine();
            Console.WriteLine("\nPermutation Combinations is:");
            int startPos = 0, endPos = str.Length - 1;
            Permutation.Permute(str, startPos, endPos);
        }
    }
}
