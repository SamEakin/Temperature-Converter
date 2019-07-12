# TemperatureConverterDocumentation

## Temperature Converter:

A console application that performs unit conversions between Fahrenheit and Celsius inputs. Written by Hemachandra Ghanta & Sam Eakin. Documentation by Sam Eakin.

---

### Business Problem:

    - It is difficult to perform the mental conversion between Fahrenheit and Celsius quickly.

    - For most users the only existing solution is to perform a Google search of the specific conversion.

---

### Solution:

    - We have created a console application which takes user input to perform an automatic conversion on the spot.

    - The user input does not require any toggling of F→C or C→F conversion.

    - The correct conversion is done automatically based on the input itself.

---

### Technology:

    - C# Console Application.

    - We implemented unit tests on our Temperature class to ensure that conversion operations are correct.

    - Development version control was enabled using Git/Github.

    - Dependencies: System: The System namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions. Microsoft.VisualStudio.TestTools.UnitTesting: The MSTest framework supports unit testing in Visual Studio. Use the classes and members in the Microsoft.VisualStudio.TestTools.UnitTesting namespace when you are coding unit tests. You can also use them when you are refining a unit test that was generated from code. Temperature: We have created a Temperature class which has Celsius and Fahrenheit child classes. Temperature objects have a Convert() method which performs the correct conversion based on the type of Temperature object that calls it.

The Constructors for these objects take an integer as input :

<!-- An innocent comment to force Markdown out of list parsing mode. See also http://meta.stackoverflow.com/a/99637 -->

    Fahrenheit fahrenheitObject = new Fahrenheit(int input)
    Celsius celsiusObject = new Celsius(int input)

The Convert() method is has separate implementations in both the Fahrenheit and Celsius classes. Calling Convert() on a temperature returns the integer value of the conversion :

<!-- An innocent comment to force Markdown out of list parsing mode. See also http://meta.stackoverflow.com/a/99637 -->

    int conversionValue = new Temperature(int inputvalue).Convert();

**Example usage :**

<!-- An innocent comment to force Markdown out of list parsing mode. See also http://meta.stackoverflow.com/a/99637 -->

    int celsiusValue = new Fahrenheit(32).Convert();
    // celsiusValue == 0

    int fahrenheitValue = new Celsius(0).Convert();
    // fahrenheitValue == 32

---

### Developer Workload Breakdown:

**Chandra:**

        - Wrote the code to recieve string input from users and sanitize the formatting.

        - Wrote the code to handle the event looping for consecutive conversion operations. 
        
**Sam:**

        - Wrote the Temperature class.

        - Refactored the code logic to utilize an OOP structure.

        - Wrote unit tests for the Temperature Convert() method.
