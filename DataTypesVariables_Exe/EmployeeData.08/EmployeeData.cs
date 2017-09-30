using System;

namespace EmployeeData
{
    internal class EmployeeData
    {
        public static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            byte age = 27;
            char gender = 'f';
            string id = "8306112507";
            string personalNumber = "27563571";
            
            Console.WriteLine($"First name: {firstName}\r\nLast name: {lastName}\r\nAge: {age}\r\nGender: {gender}\r\n" + 
                              $"Personal ID: {id}\r\nUnique Employee number: {personalNumber}");
        }
    }
}