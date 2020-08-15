using System;

namespace SelectionSort
{
    class Program
    {
        public static void selectionSort(int[] arr)
        {
            int pos_min, temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                print(arr);
                pos_min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[pos_min])
                    {
                        pos_min = j;
                    }
                }

                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                }
            }
        }

        public static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 7, 3, 4, 1 };
            Console.WriteLine("Before Shorting");
            print(arr);
            Console.WriteLine("Shorting Process starts:");
            selectionSort(arr);
            Console.WriteLine("Shorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);

            Console.ReadKey();
        }
    }
}
