using System;

namespace EmployeeData
{
    internal class EmployeeData
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name: {0}\nAge: {1}\nEmployee ID: {2}\nSalary: {3:F2}",
                Console.ReadLine(), Console.ReadLine(), Console.ReadLine().PadLeft(8, '0'), decimal.Parse(Console.ReadLine()));
        }
    }
}