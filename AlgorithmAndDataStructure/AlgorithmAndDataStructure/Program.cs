using System;

namespace AlgorithmAndDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Console.WriteLine("Choose Options");
                Console.WriteLine("1.Permutation \n2.Binary Search \n3.Insertion Sort \n4.Bubble Sort \n5.Merge Sort \n6.Anagram Detection \n7.Prime Number \n8.Prime Palindeome \n9.Exit");
                Console.WriteLine("*************************************************************************");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Permutation.PerOperation.permu();
                        break;
                    case 2:
                        BinarySearch.Operation.Binary();
                        break;

                    case 3:
                        InsertionSort.InsertionSort.ReadInput();
                        break;

                    case 4:
                        BubbleSort.BubbleSort.Bubble();
                        break;

                    case 5:
                        MergSort.MergeSort.Input();
                        break;

                    case 6:
                        AnagramDetection.Anagram.AngInput();
                        break;

                    case 7:
                        PrimeNumber.PrimeNumber.Check();
                        break;

                    case 8:
                        PrimePalindrome.Palindrome.PrimePalin();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

