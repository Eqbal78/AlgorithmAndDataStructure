using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructure.BinarySearch
{
    class Operation
    {
        public static void Binary()
        {
            Console.WriteLine("\nThis is BinarySearch Problem");

            String[] arr = { "apple", "banana", "orange", "grap", "kiwi" };
            String search = "banana";
            BinarySearch obj = new BinarySearch();
            int result = BinarySearch.binarySearch(arr, search);

            if (result >= 0)
            {
                Console.WriteLine("\nThe word " + search + " is present at index : " + result);
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");
            }
            else
            {

                Console.WriteLine("\n"+search + " is not present in list");
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");
            }
        }
    }
}
