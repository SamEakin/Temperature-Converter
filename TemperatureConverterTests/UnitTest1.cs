using System;
using TemperatureConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperatureConverterTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void FahrenheitConvertTest()
        {
            int result = new Fahrenheit(-2).Convert();
            Assert.AreEqual(-18, result);

            result = new Fahrenheit(-1).Convert();
            Assert.AreEqual(-18, result);

            result = new Fahrenheit(0).Convert();
            Assert.AreEqual(-17, result);

            result = new Fahrenheit(1).Convert();
            Assert.AreEqual(-17, result);

            result = new Fahrenheit(2).Convert();
            Assert.AreEqual(-16, result);

            result = new Fahrenheit(10).Convert();
            Assert.AreEqual(-12, result);

            result = new Fahrenheit(80).Convert();
            Assert.AreEqual(26, result);

            result = new Fahrenheit(100).Convert();
            Assert.AreEqual(37, result);
        }

        [TestMethod]
        public void CelsiusConvertTest()
        {
            int result = new Celsius(-2).Convert();
            Assert.AreEqual(29, result);

            result = new Celsius(-1).Convert();
            Assert.AreEqual(31, result);

            result = new Celsius(0).Convert();
            Assert.AreEqual(32, result);

            result = new Celsius(1).Convert();
            Assert.AreEqual(33, result);

            result = new Celsius(2).Convert();
            Assert.AreEqual(35, result);

            result = new Celsius(10).Convert();
            Assert.AreEqual(50, result);

            result = new Celsius(80).Convert();
            Assert.AreEqual(176, result);

            result = new Celsius(100).Convert();
            Assert.AreEqual(212, result);
        }
    }
}
