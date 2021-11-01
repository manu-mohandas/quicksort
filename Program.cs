using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 6, 8,17,11,36,19,13,25,21,32 };
            QuickSort(0, input.Length - 1, input);
        }

        public static void QuickSort(int start, int end, int[] array)
        {
            if (start < end)
            {
                int partition = Partition(start, end, array);
                if (partition > 1)
                    QuickSort(start, partition - 1, array);                
                if(partition + 1 < end)
                    QuickSort(partition + 1, end, array);
            }
        }

        public static int Partition(int left, int right, int[] array)
        {
            int pivot = array[left];

            while (left < right)
            {
                while (array[left] < pivot)
                    left++;

                while (array[right] > pivot)
                    right--;

                if (left < right)
                    Swap(left, right, array);
            }

            return right;

        }

        public static void Swap(int i, int j, int[] array)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
