using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] start = { 1, 3, 0, 5, 3, 5, 6, 8, 8, 2, 12 };
            int[] finish = { 4, 5, 6, 7, 9, 9, 10, 11, 12, 14, 16 };
            greedyActivitySelector(start, finish);
            Console.Read();
            List <char> charList = new List<char>();
            for(int i = 0; i < 45000; i++)
            {
                charList.Add('a');
            }
            for (int i = 0; i < 13000; i++)
            {
                charList.Add('b');
            }
            for (int i = 0; i < 12000; i++)
            {
                charList.Add('c');
            }
            for (int i = 0; i < 16000; i++)
            {
                charList.Add('d');
            }
            for (int i = 0; i < 9000; i++)
            {
                charList.Add('e');
            }
            for (int i = 0; i < 5000; i++)
            {
                charList.Add('f');
            }
            huffmanCodes(charList);
        }
        static void greedyActivitySelector(int[] start, int[] finish)
        {
            int n = start.Length;
            List<int> arrayList = new List<int>();
            arrayList.Add(1);
            int k = 0;
            for (int j = 1; j < n; j++)
            {
                if (start[j] >= finish[k])
                {
                    arrayList.Add(j+1);
                    k = j;
                }
            }
            foreach (var item in arrayList) {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        static void huffmanCodes(List<char> charList)
        {
            
        }
    }

}

