/* Temperature Converter
 * Hemachandra & Sam
 * 7/9/19
 *
 * TODO:
 * - Sanitize Inputs
 * - Repeated Inputs
 * - Interface
 */

using System;

namespace TemperatureConverter
{
    class Program
    {
        static string getInput()
        {
            Console.Write("Enter a Temperature in the format 11f or 11c: ");
            string input = Console.ReadLine();
            return input;
        }

        static string ConvertInput(string input)
        {
            string rawInput = input.ToUpper();
            rawInput = rawInput.Replace("C", "");
            rawInput = rawInput.Replace("F", "");
            return rawInput;
        }

        static void Convert()
        {
            int temp;
            string input = getInput();
            Console.WriteLine(input);
            string tempString = ConvertInput(input);
            bool check = Int32.TryParse(tempString, out temp); //fails if input is say "ddf" so trying to use TryParse
            if (check)
            {
                Console.WriteLine("See the result below:");
                string result = "0";
                if (input.EndsWith("c"))
                {
                    Console.WriteLine("Celcius to Fahrenheit conversion");
                    result = (9 * (temp + 32) / 5) + "F";
                }
                else if (input.EndsWith("f"))
                {
                    Console.WriteLine("Fahrenheit to Celsius conversion");
                    result = (5 * (temp - 32) / 9) + "C";
                }

                Console.WriteLine("{0} equals to {1}", input, result);
                // Console.WriteLine($"Result:{result}");
                ReRun();
                
            }
            else
            {
                Console.WriteLine("Conversion cannot be done. Please specify proper format");
                Convert();
            }
        }

        static void ReRun()
        {
            Console.Write("Do you want to continue?(Y/N): ");
            string response = Console.ReadLine();
            if (response == "Y" || response == "y")
            {
                Convert();
                Console.ReadLine();
            }
            else if (response == "N" || response == "n")
            {
                Console.WriteLine("Thank you for using the application. See you soon!");
            }
            else
            {
                Console.WriteLine("Enter a valid response");
                ReRun();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to our Temperature Converter!");
            Convert();
        }
    }
}
