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
            for(int i = 0; i < length; i++)
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
    }
}
