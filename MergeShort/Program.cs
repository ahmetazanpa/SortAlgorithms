using System;

namespace MergeShort
{
    class Program
    {
        static void MergeShort(int[] input, int left, int rigth)
        {
            print(input);
            if (left < rigth)
            {
                int middle = (left + rigth) / 2;
                MergeShort(input, left, middle);
                MergeShort(input, middle + 1, rigth);

                int[] leftArray = new int[middle - left + 1];
                int[] rigthArray = new int[rigth - middle];
                Array.Copy(input, left, leftArray, 0, middle - left + 1);
                Array.Copy(input, middle + 1, rigthArray, 0, rigth - middle);

                int i = 0;
                int j = 0;

                for (int k = left; k < rigth + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        input[k] = rigthArray[j];
                        j++;
                    }
                    else if (j == rigthArray.Length)
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rigthArray[j])
                    {
                        input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        input[k] = rigthArray[j];
                        j++;
                    }
                }
            }
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
            MergeShort(arr, 0, arr.Length - 1);
            Console.WriteLine("Shorting Process ends:");
            Console.WriteLine("After Sorting");
            print(arr);

            Console.ReadKey();
        }
    }
}
