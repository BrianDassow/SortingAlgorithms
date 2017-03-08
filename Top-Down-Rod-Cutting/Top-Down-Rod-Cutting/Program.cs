using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Down_Rod_Cutting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30};
            Console.Write("Enter in a length (-1 to exit): ");
            int length = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (length == -1)
                {
                    Environment.Exit(0);

                }
                else if (length < 11 && length > -2)
                {
                    Console.WriteLine("Max profit: " + memorizedCutRod(array, length));
                        
                    Console.Write("Enter in a length (-1 to exit): ");
                }
                else
                {
                    Console.Write("Enter in a length below 11 (-1 to exit): ");
                }
                
                
                length = Convert.ToInt32(Console.ReadLine());

            }
            while (length != -1);
            
            Console.Read();
        }
        public static int memorizedCutRod(int[] p, int n)
        {
            int[] r = new int[n+1];
            for (int i = 0; i < n+1; i++)
            {
                r[i] = int.MinValue;
            }
            return memorizedCutRodAux(p, n, r);
        }
        public static int memorizedCutRodAux(int[] p, int n, int[] r)
        {
            
            if (r[n] >= 0)
            {
                return r[n];
                
            }
            int q = int.MinValue;
            if (n == 0)
            {
                q = 0;
            }
            else 
            {
                q = int.MinValue;
                for (int i = 1; i <= n; i++)
                {
                    q = Math.Max(q, p[i] + memorizedCutRodAux(p, n - i, r));
                    
                    
                }
            }
            
            r[n] = q;
            return r[n];
        }

    }
}
