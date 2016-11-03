using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaprekarNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int range1;
            int range2;

            Console.WriteLine("Input Range");
            Console.WriteLine("First Number");
            Int32.TryParse(Console.ReadLine(), out range1);
            Console.WriteLine("Second Number");
            Int32.TryParse(Console.ReadLine(), out range2);

            if (range1 != 0 && range2 != 0)
            {

                Console.WriteLine("\nResults:\n");
                List<long> results = kaprekar(range1, range2);

                if (results != null)
                {
                    foreach (long result in results)
                    {
                        Console.Write(result + " ");
                    }
                } else
                    Console.WriteLine("No results found");
            }

            Console.ReadKey();

        }

        private static List<long> kaprekar(int range1, int range2)
        {

            List<int> results = new List<int>();
            List<long> r2 = new List<long>();
            long tempL;
            string temp;
            long temp2;
            long temp3;

            if (range2 < range1)
            {
                int r3 = range1;
                range1 = range2;
                range2 = r3;
            }
            
            for (long i = range1; i <= range2; i++)
            {
                tempL = (i * i);
                temp = tempL.ToString();

                for (int y = 0; y < temp.Length; y++)
                {
                    long.TryParse(temp.Substring(0, y + 1), out temp2);
                    long.TryParse(temp.Substring(y + 1), out temp3);

                    if (temp2+temp3 == i && temp3 != 0)
                    {
                        r2.Add(i);
                        y = temp.Length;
                    }
                }
            }

            return r2.Count != 0 ? r2 : null;
        }
    }
}
