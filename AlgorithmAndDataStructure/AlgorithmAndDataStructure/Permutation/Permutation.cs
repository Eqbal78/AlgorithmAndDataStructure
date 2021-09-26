using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructure.Permutation
{
    public class Permutation
    {
        /// <summary>
        /// Static method passes with some parameters
        /// </summary>
        /// <param name="str">Name of string</param>
        /// <param name="startPos">Starting position</param>
        /// <param name="endPos">End position</param>
        public static void Permute(string str, int startPos, int endPos)
        {
            //check start position is equal to end position return string
            if (startPos == endPos)
            {
                Console.WriteLine(str);
            }
            else
            {
                //Find diffrent combinations
                for (int i = startPos; i <= endPos; i++)
                {
                    str = Swap(str, startPos, i);
                    Permute(str, startPos + 1, endPos);
                    str = Swap(str, startPos, i);
                }
            }
        }
        /// <summary>
        /// Swapping the string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static String Swap(String str, int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
