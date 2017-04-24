using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 0, 0, 0, 0, 0, 0 };
            for (int i = number.Length -1; i >= 0; i--)
            {
                Console.Write(number[i]+ ", ");
            }
            Console.WriteLine();
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);
            increment(number);

            Console.Read();

        }
        static void increment(int[] array)
        {
            int i = 0;
            while (array.Length > i && array[i] == 1)
            {
                array[i] = 0;
                i++;
                

            }
            if (array.Length > i && array[i] == 0)
            {
                array[i] = 1;
            }
            

            for (int j = array.Length - 1; j >= 0; j--)
            {
                Console.Write(array[j] + ", ");
            }
            Console.WriteLine();
        }
    }
}
