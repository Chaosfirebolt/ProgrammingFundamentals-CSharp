using System;
using System.Numerics;

namespace InstructionSet
{
    internal class InstructionSet
    {
        public static void Main(string[] args)
        {
            var opCode = Console.ReadLine();
            while (opCode.ToLower() != "end")
            {
                var codeArgs = opCode.Split(' ');
                BigInteger result = 0;
                switch (codeArgs[0].ToUpper())
                {
                    case "INC":
                    {
                        var operandOne = long.Parse(codeArgs[1]);
                        result = operandOne + 1;
                        break;
                    }
                    case "DEC":
                    {
                        var operandOne = long.Parse(codeArgs[1]);
                        result = operandOne - 1;
                        break;
                    }
                    case "ADD":
                    {
                        var operandOne = long.Parse(codeArgs[1]);
                        var operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                    case "MLA":
                    {
                        BigInteger operandOne = int.Parse(codeArgs[1]);
                        BigInteger operandTwo = int.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
                }
                Console.WriteLine(result);
                opCode = Console.ReadLine();
            }
        }
    }
}