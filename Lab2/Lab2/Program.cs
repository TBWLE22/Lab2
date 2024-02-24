using System;
//using factorial;
//using Quadratic;
//using student;
//using time;
using System.IO;
using readncopy;
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
    class fileoperation
    {
        static void Main(String[] args)
        {
            string sourceFilePath = @"D:\Shreyan Bista\6th Sem\NCC\Lab2\Lab2\bin\Debug\net6.0\input.txt";
            string destinationFilePath = @"D:\Shreyan Bista\6th Sem\NCC\Lab2\Lab2\bin\Debug\net6.0\output.txt";
            Readncopy readncopy = new Readncopy();
            readncopy.CopyFile(sourceFilePath, destinationFilePath);
            string inputContent = readncopy.ReadFile(sourceFilePath);
            if (inputContent != null)
            {
                Console.WriteLine($"{sourceFilePath}");
                Console.WriteLine(inputContent);
            }

            string outputContent = readncopy.ReadFile(destinationFilePath);
            if (outputContent != null)
            {
                Console.WriteLine($"{destinationFilePath}");
                Console.WriteLine(outputContent);
            }
        }

    }
}
