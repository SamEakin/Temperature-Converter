/* Temperature Converter
 * Hemachandra & Sam
 * 7/9/19
 *
 * TODO:
 * - Interface
 */

using System;

namespace TemperatureConverter
{

    class Program
    {
        private static string GetInput()
        {
            Console.Write("Enter a Temperature in the format 11f or 11c : ");
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine(input);
            return input;
        }


        private static Temperature ReadTemperature(string input)
        {
            if (input.EndsWith("F"))
            {
                int degreeValue = RemoveInputUnitIdentifier(input);
                Fahrenheit inputTemperature = new Fahrenheit(degreeValue);
                return inputTemperature;
            }
            else if (input.EndsWith("C"))
            {
                int degreeValue = RemoveInputUnitIdentifier(input);
                Celsius inputTemperature = new Celsius(degreeValue);
                return inputTemperature;
            }
            else
            {
                Console.WriteLine("Incorrect Input Format. Make sure you end with \"F\" or \"C\"");
                string newInput = GetInput();
                return ReadTemperature(newInput);
            }
        }


        private static int RemoveInputUnitIdentifier(string input)
        {
            bool validInput = false;

            if (input.Contains("F") || input.Contains("C"))
            {
                input = input.Replace("C", "");
                input = input.Replace("F", "");
                validInput = true;
            }
            else
            {
                validInput = false;
            }

            int degreeValue;
            validInput = Int32.TryParse(input, out degreeValue);

            if (validInput)
            {
                return degreeValue;
            }
            else
            {
                Console.WriteLine("Invalid input format. Make sure you entered numbers followed by F or C.");
                return RemoveInputUnitIdentifier(GetInput());
            }
        }


        static bool ReRun()
        {
            Console.Write("Do you want to continue?(Y/N): ");
            string response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                return true;
            }
            else if (response == "N")
            {
                Console.WriteLine("Thank you for using the application. See you soon!");
                return false;
            }
            else
            {
                Console.WriteLine("Huh?");
                return ReRun();
            }
        }


        public static bool Run()
        {
            string input = GetInput();
            Temperature inputTemperature = ReadTemperature(input);
            Console.WriteLine(inputTemperature.Convert());
            return ReRun();
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to our Temperature Converter!");
            bool keepRunning;
            do
            {
               keepRunning = Run();
            }
            while (keepRunning);
        }
    }
}
