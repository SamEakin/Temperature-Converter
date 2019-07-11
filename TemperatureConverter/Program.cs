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
            Console.WriteLine("Enter a Temperature in the format 11f or 11c");
            string input = Console.ReadLine();
            return input;
        }


        static int ConvertInput(string input)
        {
            int temp;
            string rawInput = "";
            = input.Replace("c", "");
            rawInput = input.Replace("f", "");

            bool goodInput = Int32.TryParse(rawInput, out temp);

            while (!goodInput)
            {
                Console.WriteLine("Incorrect input format. Try again.");
                
            }

            return temp;
        }


        static void Convert()
        {
            string input = getInput();
            Console.WriteLine(input);
            int temp = ConvertInput(input);         
            string result = "0";
            if (input.EndsWith("c"))
            {
                Console.WriteLine("Celcius");               
                result = (9 * (temp + 32) / 5) + "F";               
            }
            else if (input.EndsWith("f"))
            {
                Console.WriteLine("Fahrenheit to Celsius conversion");             
                result = (5 * (temp - 32) / 9) + "C";
            }
            else
            {
                Console.WriteLine("Please Enter a valid input format");
                Convert();
            }

            Console.WriteLine($"Result:{result}");
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to our Temperature Converter!");
            Convert();
        }
    }
}
