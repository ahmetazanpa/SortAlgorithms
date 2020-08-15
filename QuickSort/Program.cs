using System;
using Microsoft.VisualBasic.CompilerServices;

namespace QuickSort
{
    class Program
    {
        public static void QuickSort(int[] input, int left, int rigth)
        {
            if (left < rigth)
            {
                int q = Partiton(input, left, rigth);
                QuickSort(input, left,q-1);
                QuickSort(input, q + 1, rigth);
            }
        }

        private static int Partiton(int[] input, int left, int rigth)
        {
            print(input);
            int pivot = input[rigth];
            int temp;

            int i = left;

            for (int j = left; j < rigth; j++)
            {
                if (input[j] <= pivot)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[rigth] = input[i];
            input[i] = pivot;

            return i;
        }

        static void print(int[] arr)
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
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Shorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);

            Console.ReadKey();
        }
    }
}
