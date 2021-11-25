using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Sort
    {
        public static void Bubble(int[] number)
        {
            int temp;
            int length = number.Length;
            Console.WriteLine("before sorting:");
            for(int i = 0; i < length; i++)
            {
                Console.WriteLine(number[i]);
            }
            for(int i = 0; i < length-1; i++)
            {
                for(int j = 0; j < length-1; j++)
                {
                    if (number[j] > number[j + 1])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("after sorting the number");
            for(int i=0;i<length;i++)
            {
                Console.WriteLine(number[i] + " ");
            }
        }
        public static void InsertionSort(int[] number)
        {
            int n = number.Length, temp;
            Console.WriteLine("before sorting:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(number[i]);
            }
            for(int i = 1; i < n; i++)
            {
                temp = number[i];
                int j = i - 1;
                while (j >= 0 && number[j] > temp)
                {
                    number[j + 1] = number[j];
                    j--;
                }
                number[j + 1] = temp;
            }
            Console.WriteLine("after sorting the array");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}
