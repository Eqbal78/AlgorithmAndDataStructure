 using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructure.BubbleSort
{
    public class BubbleSort
    {
        /// <summary>
        /// Bubble sort method
        /// </summary>
        public static void Bubble()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            Console.WriteLine("This is Bubble Sort Problem\n");
            Console.WriteLine("Original array :");
            //treverse the array
            foreach (int aa in arr)
            {
                Console.Write(aa + " ");
            }
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //swapping
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n\nSorted array:");
            //after sorting traverse array
            foreach (int p in arr)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine("\n-----------------------------------\n");
        }
    }
}
