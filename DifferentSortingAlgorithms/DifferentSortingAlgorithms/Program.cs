using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentSortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startingArray = { 5, 3, 1, 3, 9, 10, 600,9599,1,3,2,1,1,5,7 };
           // int[] insertionSortArray = InsertionSort(startingArray);
            /*
            for (int i = 0; i < startingArray.Length; i++)
            {
                Console.Write(insertionSortArray[i]);
                if (startingArray.Length -1 != i)
                {
                    Console.Write(", ");
                }
            }
            */

            int[] linearSearchArray = LinearSearch(startingArray);

            for (int i = 0; i < linearSearchArray.Length; i++)
            {
                Console.Write(linearSearchArray[i]);
                if (startingArray.Length - 1 != i)
                {
                    Console.Write(", ");
                }
            }

            Console.Read();
        }
        public static int[] InsertionSort(int[] arr)
        {
            int[] sortedArray = arr;
            for (int i = 1; i < sortedArray.Length; i++)
            {
                int key;
                int j = i;
                while (j > 0 && sortedArray[j-1] > sortedArray[j])
                {
                    key = sortedArray[j];
                    sortedArray[j] = sortedArray[j-1];
                    sortedArray[j - 1] = key;
                    j--;
                    
                }
                
                Console.Write("CurrentIteration " + i + ": ");
                foreach (var item in sortedArray)
                {
                    Console.Write(item + ", ");

                }
                Console.WriteLine();
            }
            
            return sortedArray;
        }

        public static int[] LinearSearch(int[] arr)
        {
            int[] sortedArray = arr;
            int smallest;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                smallest = sortedArray[i];
                for (int j = i+1; j < sortedArray.Length; j++)
                {
                    if (sortedArray[j] < smallest)
                    {
                        int temp = sortedArray[i];
                        smallest = sortedArray[j];
                        sortedArray[i] = sortedArray[j];
                        sortedArray[j] = temp;
                    }

                }
                
            }
            return sortedArray;
        }
    }
}
