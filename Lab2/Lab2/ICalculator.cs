using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterface
{
    public interface ICalculator
    {
        int Add(int x, int y);
        int Diff(int x, int y);
    }
    public class Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Diff(int x, int y) 
        { 
            return x - y;
        }
    }
}
