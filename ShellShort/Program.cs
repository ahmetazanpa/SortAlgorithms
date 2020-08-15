using System;

namespace ShellShort
{
    class Program
    {
        public static void shellShort(int[] input, int array_size)
        {
            int i, j, increment, temp;
            increment = 3;
            while (increment > 0)
            {
                print(input);
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = input[i];
                    while ((j >= increment) && (input[j-increment] > temp))
                    {
                        input[j] = input[j - increment];
                        j = j - increment;
                    }
                    input[j] = temp;
                }

                if (increment / 2 != 0) increment = increment / 2;
                else if (increment == 1) increment = 0;
                else increment = 1;
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
            shellShort(arr, arr.Length);
            Console.WriteLine("Shorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);

            Console.ReadKey();
        }
    }
}
