using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    public class Student
    {
        public int age;
        public string name;

        public void Input()
        {
            Console.WriteLine("Enter student's age: ");
            age = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter student's name: ");
            name = Console.ReadLine();
        }
    }
}
