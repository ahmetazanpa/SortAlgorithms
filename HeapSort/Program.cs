using System;

namespace HeapSort
{
    class Program
    {

        public static void HeapShort(int[] input)
        {
            //5, 7, 3, 4, 1 => Length : 5
            int heapSize = input.Length;

            for (int p = (heapSize-1)/2; p >= 0; p--)
                MaxHeap(input, heapSize, p);

            for (int i = input.Length-1; i > 0; i--)
            {
                int temp = input[i];
                input[i] = input[0];
                input[0] = temp;
                heapSize--;

                MaxHeap(input, heapSize, 0);

            }
        }

        private static void MaxHeap(int[] input, int heapSize, int index)
        {
            print(input);
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && input[left] > input[index]) largest = left;
            else largest = index;
            if (right < heapSize && input[right] > input[largest]) largest = right;

            if (largest != index)
            {
                int temp = input[index];
                input[index] = input[largest];
                input[largest] = temp;

                MaxHeap(input, heapSize, largest);
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
            int[] arr = {5, 7, 3, 4, 1};
            Console.WriteLine("Before Shorting");
            print(arr);
            Console.WriteLine("Shorting Process starts:");
            HeapShort(arr);
            Console.WriteLine("Shorting Process ends:");
            Console.WriteLine("After Shorting");
            print(arr);
            Console.ReadKey();
        }
    }
}
