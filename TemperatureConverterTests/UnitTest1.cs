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
            Fahrenheit temp = new Fahrenheit(0);
            int result = temp.Convert();
            Assert.AreEqual(-17, result);
        }

        [TestMethod]
        public void CelsiusConvertTest()
        {
            Celsius temp = new Celsius(0);
            int result = temp.Convert();
            Assert.AreEqual(32, result);
        }

        /*
        [TestMethod]
        public void RemoveInputUnitIdentifierTest()
        {
            int result = RemoveInputUnitIdentifier("10f");
            Assert.AreEqual(10, result);
        }
        */
    }
}
