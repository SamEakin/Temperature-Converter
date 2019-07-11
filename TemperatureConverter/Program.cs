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
        private static string getInput()
        {
            Console.Write("Enter a Temperature in the format 11f or 11c: ");
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine(input);
            return input;
        }


        private static int RemoveInputUnitIdentifier(string input)
        {
            input = input.Replace("C", "");
            input = input.Replace("F", "");
            int degreeValue = Int32.Parse(input);
            return degreeValue;
        }

        /*
        private static string CheckTemperatureUnitType()
        {

        }
        */

        /*
        public static void Convert()
        {
            string input = getInput();
            int degreeValue = RemoveInputUnitIdentifier(input);

            bool successfulInput = Int32.TryParse(input, out int temp);
            if (successfulInput)
            {
                if (input.EndsWith("c"))
                {
                    Celsius inputTemperature = new Celsius(degreeValue);
                }
                else if (input.EndsWith("f"))
                {
                    Fahrenheit inputTemperature = new Fahrenheit(degreeValue);
                }
            }
        }
        */


        static void ReRun()
        {
            Console.Write("Do you want to continue?(Y/N): ");
            string response = Console.ReadLine().ToUpper();
            Console.WriteLine(response);
            if (response == "Y")
            {
                //Convert();
            }
            else if (response == "N")
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
            //Console.WriteLine("Hello Welcome to our Temperature Converter!");
            //Convert();
            //Console.WriteLine("Exitted succesfully.");

        }
    }
}
