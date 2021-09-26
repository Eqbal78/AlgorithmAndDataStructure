using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructure.InsertionSort
{
    public class InsertionSort
    {
        /// <summary>
        /// Read the input from user
        /// </summary>
        public static void ReadInput()
        {
            Console.WriteLine("\nThis is Insertion Sort problem\n");
            Console.WriteLine("Enter size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter elements of an array : ");
            string[] arr = new string[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Insertion(arr, size);

        }
        
        /// <summary>
        /// sorting the string using insertion sort
        /// </summary>
        /// <param name="arr">String Array</param>
        /// <param name="length">Length of Array</param>
        public static void Insertion(string[] arr, int length)
        {
            for (int i = 1; i < length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j - 1].CompareTo(arr[j]) > 0)
                    {
                        //call swapping method
                        Swap(arr, j, j - 1);
                     
                    }
                    else
                        break;
                }
            }
            Console.WriteLine("\nAfter performing Insertion Sort : ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n-----------------------------------------------\n");
        }

        /// <summary>
        /// Swapping the array
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void Swap(String[] arry, int i, int j)
        {
            string temp;
            temp = arry[i];
            arry[i] = arry[j];
            arry[j] = temp;

        }
    }
}
