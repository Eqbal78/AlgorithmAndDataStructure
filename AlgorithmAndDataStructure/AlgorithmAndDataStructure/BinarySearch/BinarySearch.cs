using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructure.BinarySearch
{
    public class BinarySearch
    {
       
        public static int binarySearch(String[] arr, String search)
        {
            int num = 0, len = arr.Length - 1;
            while (num <= len)
            {
                int mid = num + (len - num) / 2;

                int res = search.CompareTo(arr[mid]);

                // Check if x is present at mid
                if (res == 0)
                    return mid;

                // If x greater, ignore left half
                if (res > 0)
                    num = mid + 1;

                // If x is smaller, ignore right half
                else
                    len = mid - 1;
            }

            return -num;
        }

    }
}
