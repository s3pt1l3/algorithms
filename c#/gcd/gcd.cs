using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(gcd(20, 4));
            Console.ReadKey();
        }
        static int gcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b) 
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            if (!(a == 0 && b == 0))
            {
                return Math.Max(a, b);
            }
            return 0;
        }
    }
}
