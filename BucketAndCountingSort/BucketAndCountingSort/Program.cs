using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketAndCountingSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] countingSortArr = new int[15];
            double[] bucketSortArr = new double[15];

            Random rand = new Random();
            for (int i = 0; i < countingSortArr.Length; i++)
            {
                countingSortArr[i] = rand.Next(0, 100);
                bucketSortArr[i] = (double)rand.Next(0, 10000) / (double)10000.0;
            }

            Console.WriteLine("Unsorted counting sort values:");
            for (int i = 0; i < countingSortArr.Length; i++)
            {
                Console.WriteLine(countingSortArr[i]);
            }
            int[] sortedCountingArray = CountingSort(countingSortArr);
            Console.WriteLine("Sorted counting sort values:");
            for (int i = 0; i < sortedCountingArray.Length; i++)
            {
                Console.WriteLine(sortedCountingArray[i]);
            }

            Console.WriteLine("Unsorted bucket sort values:");
            for (int i = 0; i < bucketSortArr.Length; i++)
            {
                Console.WriteLine(bucketSortArr[i]);
            }
            double[] sortedBucketArray = BucketSort(bucketSortArr);
            Console.WriteLine("Sorted bucket sort values:");
            for (int i = 0; i < sortedBucketArray.Length; i++)
            {
                Console.WriteLine(sortedBucketArray[i]);
            }

            Console.ReadLine();
        }

        public static int[] CountingSort(int[] array)
        {
            int[] sortedArray = new int[array.Length];

            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

                else if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int[] count = new int[max - min + 1];

            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] - min]++;
            }

            count[0]--;
            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i] + count[i - 1];
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[count[array[i] - min]--] = array[i];
            }

            return sortedArray;
        }

        public static double[] BucketSort(double[] array)
        {
            double[] sortedArray = new double[array.Length];

            List<List<double>> buckets = new List<List<double>>();

            for (int i = 0; i < array.Length; i++)
            {
                List<double> a = new List<double>();
                buckets.Add(a);
            }

            foreach (double value in array)
            {
                int bucketNumber = (int)((double)value * array.Length);
                buckets[bucketNumber].Add(value);
            }

            int bucketNumberForArray = 0;
            foreach (List<double> bucket in buckets)
            {
                double[] arr = bucket.ToArray();
                InsertionSort(arr);

                foreach (double element in arr)
                {
                    sortedArray[bucketNumberForArray] = element;
                    bucketNumberForArray++;
                }
            }

            return sortedArray;
        }

        private static void InsertionSort(double[] array)
        {
            int j;
            double temp;

            for (int i = 1; i < array.Length; i++)
            {
                j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;
                }
            }
        }

    }
}
