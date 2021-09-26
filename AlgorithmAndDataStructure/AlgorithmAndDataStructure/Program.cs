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
                Console.WriteLine("1.Permutation \n2.Binary Search \n3.Insertion Sort \n4.Exit");
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
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

