using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade");
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            doj = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name : \t" + name + "\n Age: " + age + "\n Grade: \t"
                + grade + "\n Salary: \t  " + salary + "\n Date of Joining: \t " + doj);
            Console.ReadKey();
        }
    }
}
