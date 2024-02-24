using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    public class quadratic
    {
        public double a, b, c, x1, x2;

        public void Input()
        {
            Console.Write("Enter the vlaue of a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter the vlaue of b:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter the vlaue of c:");
            c = double.Parse(Console.ReadLine());
        }

        public double[] Calculate()
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine(" No real roots exist.");
                return null;
            }
            else if (discriminant == 0 )
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }

        else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            return new double[] { x1, x2 };
        }
    }
}
