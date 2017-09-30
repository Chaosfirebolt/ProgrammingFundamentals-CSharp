using System;

namespace BlankReceipt
{
    internal class BlankReceipt
    {
        public static void Main(string[] args)
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        
        private static void PrintHeader() {
            Console.WriteLine("CASH RECEIPT\r\n------------------------------");
        }

        private static void PrintBody() {
            Console.WriteLine("Charged to____________________\r\nReceived by___________________");
        }

        private static void PrintFooter() {
            Console.WriteLine("------------------------------\r\n© SoftUni");
        }
    }
}