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
            Console.WriteLine(recursiveFib(4));
            Console.ReadKey();
        }
        static int recursiveFib(int pos)
        {
            if (pos < 2)
            {
                return pos;
            }
            return recursiveFib(pos - 2) + recursiveFib(pos - 1);
        }
    }
}
