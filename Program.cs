using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void sort(int[] arr)
        {
            if (arr == null || arr.Length < 2)
                return;

            mergeSort(arr, 0, arr.Length - 1);
        }

        public static void mergeSort(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int mid = (start + end) / 2;
                mergeSort(arr, start, mid);
                mergeSort(arr, mid + 1, end);
                merge(arr, start, mid, end);
            }
        }

        public static void merge(int[] array, int start, int mid, int end)
        {
            int[] copyToArray = new int[end - start + 1];

            int leftIndex = start;
            int rightIndex = mid + 1;
            int arrayIndex = 0;
            while (leftIndex <= mid && rightIndex <= end)
            {
                int currLeft = array[leftIndex];
                int currRight = array[rightIndex];
                if (currLeft <= currRight)
                {
                    copyToArray[arrayIndex] = currLeft;
                    leftIndex++;
                }
                else
                {
                    copyToArray[arrayIndex] = currRight;
                    rightIndex++;
                }
                arrayIndex++;

            }
            while (leftIndex <= mid)
            {
                copyToArray[arrayIndex] = array[leftIndex];
                leftIndex++;
                arrayIndex++;
            }
            while (rightIndex <= end)
            {
                copyToArray[arrayIndex] = array[rightIndex];
                rightIndex++;
                arrayIndex++;
            }
            for (int i = 0; i < end - start + 1; i++)
            {
                array[start + i] = copyToArray[i];
            }
        }

        public static void printArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arr = { 7, 3, 9, 4, -7, 5, 1, 9, 4, };
            sort(arr);
            printArr(arr);

        }
    }
}
