using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial 
{
    public class Factorial
    {
        public int calculatefactorial(int n)
        {
            int fact = 1;
            if(n < 0)
            {
                Console.WriteLine("Error! Factorial of a negative number does not exist.");
            }
            else
            {
                for (int i =1; i<= n; i++)
                {
                    fact *= i;
                }
            }
            return fact;
        }
    }
}
