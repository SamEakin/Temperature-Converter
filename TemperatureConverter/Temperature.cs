using System;
namespace TemperatureConverter
{
    public abstract class Temperature
    {
        public int degrees { get; set; }

        public Temperature(int input)
        {
            this.degrees = input;
        }

        public abstract int Convert();
    }


    public class Fahrenheit : Temperature
    {
        public Fahrenheit (int input) : base(input){}

        public override int Convert()
        {
            Console.WriteLine("Fahrenheit to Celsius conversion");
            int result = (5 * (this.degrees - 32) / 9);
            return result;
        }
    }

        
    public class Celsius : Temperature
    {
        public Celsius(int input) : base(input) { }

        public override int Convert()
        {
            Console.WriteLine("Celcius to Fahrenheit conversion");
            int result = (9 * (this.degrees + 32) / 5);
            return result;
        }
    }
}
