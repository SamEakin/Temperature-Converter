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

        static int convertInput(string input)
        {
            string rawInput = input.Replace("c", "");
            rawInput = input.Replace("f", "");
            int temp = Int32.Parse(rawInput);
            return temp;
        }

        static void convert()
        {
            string input = getInput();
            Console.WriteLine(input);
            int temp = 0;
            if (input.EndsWith("c"))
            {
                Console.WriteLine("Celcius");
                temp = convertInput(input);
            }
            else if (input.EndsWith("f"))
            {
                Console.WriteLine("Fahrenheit");
                temp = convertInput(input);
            }
            else
            {
                Console.WriteLine("Please Enter a valid input format");
                convert();
            }

            Console.WriteLine(temp);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to our Temperature Converter!");
            convert();
        }
    }
}
