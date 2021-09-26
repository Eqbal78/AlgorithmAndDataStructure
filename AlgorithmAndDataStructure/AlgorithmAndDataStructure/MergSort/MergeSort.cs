using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructure.MergSort
{
    class MergeSort
    {
        /// <summary>
        /// Sorting by using Merge sort
        /// </summary>
        /// <param name="numbers">String</param>
        /// <param name="left">Left Element</param>
        /// <param name="mid">Mid Element</param>
        /// <param name="right">Right Element</param>
        static public void Merge(string[] numbers, int left, int mid, int right)
        {
            //Declare array and variable
            string[] temp = new string[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left].CompareTo(numbers[mid]) < 0)
                {
                    temp[tmp_pos++] = numbers[left++];
                }
                else
                {
                    temp[tmp_pos++] = numbers[mid++];
                }
            }
            // Copy data to temp arrays
            while (left <= left_end)
            {
                temp[tmp_pos++] = numbers[left++];
            }

            while (mid <= right)
            {
                temp[tmp_pos++] = numbers[mid++];
            }

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        /// <summary>
        /// using recursion check all element
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        static public void Merge_Recursive(string[] numbers, int left, int right)
        {
            int mid;
            //if right is greater the recurion call
            if (right > left)
            {
                mid = (right + left) / 2;
                Merge_Recursive(numbers, left, mid);
                Merge_Recursive(numbers, (mid + 1), right);

                Merge(numbers, left, (mid + 1), right);
            }
        }

        /// <summary>
        /// Input method to take an input
        /// </summary>
        public static void Input()
        {
            string[] numbers = { "Mango", "Orange", "Apple", "Banana", "Graps", "Kiwi", "40", "Ant", "10" };
            int len = 9;
            ///before sorting array
            Console.WriteLine("\nGiven Array");
            Console.WriteLine("**************************\n");
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
            //after sorting array
            Console.WriteLine("\nMergeSort By Recursive Method");
            Console.WriteLine("*******************************\n");
            Merge_Recursive(numbers, 0, len - 1);
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\n----------------------------------------------------\n");
        }
    }

}
