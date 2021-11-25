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
                Console.WriteLine("CHOOSE ONE OPTION FOR SORT\n1.Insertion Sort\n2.Bubble Sort\n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Sort.InsertionSort(numbers);
                        break;
                    case 2:
                        Sort.Bubble(numbers);
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Your choice should bebetween 1 to 3");
                        break;
                }
            }
        }
    }
}
