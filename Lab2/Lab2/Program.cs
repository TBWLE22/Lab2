//using CalculatorInterface;
using System;
using System.Net.Sockets;
//using factorial;
//using Quadratic;
//using student;
//using time;
//using readncopy;
//using Dispg;
//using ShapesInterface;
//using vehicle;
//using Employeeinfo;
using SumOfOdd;
namespace Lab2
{
    /* internal class Program
       {
               public delegate int calcfactorial(int x);
                  static void Main(string[] args)
                  {
                      Factorial factorial = new Factorial();
                      calcfactorial calculatefactorial = new calcfactorial(factorial.calculatefactorial);
                      Console.WriteLine("Enter an integer");
                      int input = Convert.ToInt32(Console.ReadLine());
                      int result = calculatefactorial.Invoke(input);
                      Console.WriteLine($"The factorial of {input} is {result}");
                  }
              }*/
    /*     class Imain
           {
               public static void Main(string[] args)
               {
                   quadratic quad = new quadratic();
                   quad.Input();
                   double[] roots = quad.Calculate();
                   if (roots != null)
                   {
                       Console.WriteLine("Root 1: " + roots[0]);
                       Console.WriteLine("Root 2: " + roots[1]);
                   }
               }
           } */
  /*  class Imain
    {
        public static void Main(string[] args)
        {
            Student[] lstStudent = new Student[5];
            for (int i = 0; i < lstStudent.Length; i++)
            {
                Console.WriteLine($"Enter details for student {i + 1}:");
                lstStudent[i] = new Student();
                lstStudent[i].Input();
            }
            Console.WriteLine("\nStudents aged 24 or older:");
            foreach (Student student in lstStudent)
            {
                if (student.age >= 24)
                {
                    Console.WriteLine($"Name: {student.name}, Age: {student.age}");
                }
            }
        }
    } */
 /* class TimeDemo
    {
        static void Main(string[] args)
        {
            Time t1 = new Time { hr = 5, min = 40, sec = 40};
            Time t2 = new Time { hr = 4, min = 40, sec = 50 };

            Time t3 = new Time();
            t3 = t3.Sum(t1, t2);

            Console.WriteLine($"t1 --> {t1}");
            Console.WriteLine($"t2 --> {t2}");
            Console.WriteLine($"Total Sum t3 --> {t3}");
        }
    } */
  /*  class fileoperation
    {
        static void Main(String[] args)
        {
            string inputFilePath = @"D:\Shreyan Bista\6th Sem\NCC\Lab2\Lab2\bin\Debug\net6.0\input.txt";
            string outputFilePath = @"D:\Shreyan Bista\6th Sem\NCC\Lab2\Lab2\bin\Debug\net6.0\output.txt";

            string content = Readncopy.Readfile(inputFilePath);
            if (content != null)
            {
                Readncopy.CopyFile(content,outputFilePath);
            } 
            else
            {
                Console.WriteLine("File reading failed. Can't copy.");
            }
        }

    } */
  /*  class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Input.txt";
            Displayg.Displaytheg(filePath);
        }
    } */
 /* class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int resultAdd = calc.Add(6, 10);
            int resultDiff = calc.Diff(22, 18);

            Console.WriteLine("Sum : " + resultAdd);
            Console.WriteLine("Difference: " +resultDiff);
        }
    } */
 /*   class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(6, 8);
            Square square = new Square(12);

            rectangle.Get();
            rectangle.Display();
            Console.WriteLine();
            square.Get();
            square.Display();
        }
    } */
/*    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane ("Zeppelin LZ 1", "Luftschiffbau Zeppelin", 5);

            Console.WriteLine("Airplane Details:");
            airplane.DisplayDetails();
            Console.WriteLine();
            Console.WriteLine("Status");
            airplane.StartEngine();
            airplane.Takeoff();
            airplane.Land();
            airplane.StopEngine();
        }
    } */
 /*   public class Imain
    {
        static void Main(String[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {Id = 1,Name = "Ramesh", Address = "Thimi", Salary = 50000 },
                new Employee {Id = 1,Name = "Suresh", Address = "Chyamashingh", Salary = 60000 },
                new Employee {Id = 1,Name = "Kaman", Address = "Kamalbinayak", Salary = 35000 },
                new Employee {Id = 1,Name = "Logan", Address = "Metropolis", Salary = 45000 },
                new Employee {Id = 1,Name = "Slade", Address = "Gotham", Salary = 55000 }
            };
            var highpaid = from emp in employees where emp.Salary > 40000 select emp;

            Console.WriteLine("Employees with Salary > 40000:");
            foreach(var emp in highpaid)
            {
                Console.WriteLine($"ID: {emp.Id}\t Name: {emp.Name}\t  Address: {emp.Address}\t  Salary: {emp.Salary}");
            }
        }
    } */
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i ++ )
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sumOfodd = SumOfOdd.Array.OddSum(numbers);
            Console.WriteLine($"Sum of odd numbers in the array: {sumOfodd}");
        }
    }
}
