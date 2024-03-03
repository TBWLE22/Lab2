using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdd
{
    public class Array
    {
        public static int OddSum(int[] numbers)
        {
            int sumOfodd = numbers.Where(num  => num % 2 != 0).Sum();
            return sumOfodd;
        }
    }
}
