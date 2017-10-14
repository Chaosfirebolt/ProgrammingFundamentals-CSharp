using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LettersChangeNumbers
{
    internal class LettersChangeNumbers
    {
        public static void Main(string[] args)
        {
            var operands = ParseInput(Console.ReadLine());
            var result = 0D;
            foreach (var operand in operands)
            {
                result += ProcessOperand(operand);
            }
            Console.Write($"{result:F2}");
        }

        private static double ProcessOperand(string operand)
        {
            var firstLetter = operand[0];
            var number = double.Parse(operand.Substring(1, operand.Length - 2));
            number = char.IsUpper(firstLetter)
                ? number / PositionInAlphabet(firstLetter)
                : number * PositionInAlphabet(firstLetter);
            var lastLetter = operand[operand.Length - 1];
            number = char.IsUpper(lastLetter)
                ? number - PositionInAlphabet(lastLetter)
                : number + PositionInAlphabet(lastLetter);
            return number;
        }

        private static int PositionInAlphabet(char character)
        {
            return char.IsUpper(character) ? character - 64 : character - 96;
        }

        private static string[] ParseInput(string input)
        {
            return Regex.Split(input, "\\s+").Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }
    }
}