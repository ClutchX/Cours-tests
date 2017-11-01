using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConverterLogic;

namespace UnitTests
{
    [TestClass]
    public class RomanToArabTests
    {
        [TestMethod]
        public void TestI()
        {
            //Arrange
            IConverter converter = new MyConverter();

            //Act
            var result = converter.Convert("1");

            //Assert
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void TestV()
        {
            //Arrange
            IConverter converter = new MyConverter();

            //Act
            var result = converter.Convert("5");

            //Assert
            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void TestX()
        {
            //Arrange
            IConverter converter = new MyConverter();

            //Act
            var result = converter.Convert("10");

            //Assert
            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void TestL()
        {
            //Arrange
            IConverter converter = new MyConverter();

            //Act
            var result = converter.Convert("50");

            //Assert
            Assert.AreEqual("L", result);
        }

        [TestMethod]
        public void TestC()
        {
            //Arrange
            IConverter converter = new MyConverter();

            //Act
            var result = converter.Convert("100");

            //Assert
            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void TestD()
        {
            //Arrange
            IConverter converter = new MyConverter();

            //Act
            var result = converter.Convert("500");

            //Assert
            Assert.AreEqual("D", result);
        }

        [TestMethod]
        public void TestM()
        {
            //Arrange
            IConverter converter = new MyConverter();

            //Act
            var result = converter.Convert("1000");

            //Assert
            Assert.AreEqual("M", result);
        }

        [TestMethod]
        public void TestIV()
        {
            //Arrange
            IConverter converter = new MyConverter();

            //Act
            var result = converter.Convert("4");

            //Assert
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void TestVI()
        {
            //Arrange
            IConverter converter = new MyConverter();

            //Act
            var result = converter.Convert("6");

            //Assert
            Assert.AreEqual("VI", result);
        }
    }
}
