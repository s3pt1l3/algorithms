using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json_app
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
            int a = 0;
            int b = 1;
            for (int i = 2; i < pos + 1; ++i)
            {
                int c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}
