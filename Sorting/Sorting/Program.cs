using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 100, 200, 50, 700, 500, 400 };
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE ONE OPTION FOR SORT\n1.BubbleSort\n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Sort.Bubble(numbers);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
