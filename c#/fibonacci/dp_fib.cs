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
            int[] nums = new int[pos + 1];
            nums[0] = 0;
            nums[1] = 1;
            for (int i = 2; i < pos + 1; ++i)
            {
                nums[i] = nums[i - 2] + nums[i - 1];
            }
            return nums[pos];
        }
    }
}
