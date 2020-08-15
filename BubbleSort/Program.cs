using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {120, 23, 453, 123, 2446, 2324, 5, 77, 4646, 12};
            int temp = 0;
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length -1 ; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
