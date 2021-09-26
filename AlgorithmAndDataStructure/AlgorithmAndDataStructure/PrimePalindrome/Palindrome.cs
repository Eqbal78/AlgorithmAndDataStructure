using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructure.PrimePalindrome
{
    class Palindrome
    {
        public static void PrimePalin()
        {
            for (int i = 0; i <= 1000; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("The prime numbers are : " + i + "\n");
                        break;
                    }

                }

                int r, sum = 0, temp;
                temp = i;
                while (i > 0)
                {
                    r = i % 10;
                    sum = (sum * 10) + r;
                    i = i / 10;
                }
                if (temp == sum)
                {
                    Console.Write("Number is Palindrome." + i+"\n");
                    break;
                }
                else
                {
                    Console.Write("Number is not Palindrome" + i+"\n");
                    break;
                }
                
                
            }

        }

    }
}
