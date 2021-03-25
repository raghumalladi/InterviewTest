using System;
using System.Linq;
using System.Text;

namespace ConsoleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string consoleInput = Console.ReadLine();
                if (consoleInput.Length < 1)
                {
                    Console.WriteLine("Please enter valid input string");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write(ExecuteLogic(consoleInput));
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Write("Error Occured while processing string : " + ex.Message);
            }
        }

        private static string ExecuteLogic(string inputString)
        {
            string[] stringArray = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string input in stringArray)
            {
                if (input.Length > 1)
                {
                    string output = string.Concat(input[0], input.Substring(1, input.Length - 2).Distinct().Count(), input[input.Length - 1]);
                    stringBuilder.Append(output).Append(' ');
                }
                else
                {
                    stringBuilder.Append(input + "0").Append(' ');
                }
            }
            return stringBuilder.ToString();
        }
    }
}
