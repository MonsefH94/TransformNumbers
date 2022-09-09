using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using transformNumbers;

namespace TransformNumbersTests
{
    [TestClass]
    public class TransformNumbersTests
    {

        #region Errors_Tests
        [TestMethod]
        public void Should_return_Throw_Exception_When_More_Than_Five_Digits_Entered()
        {
            //Arrange
            int enterNumbre = 10000;
            TransformNumbers transform = new TransformNumbers();

            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => transform.DigitstoRomains(enterNumbre), "Please Enter a number with 4 digits max");
        }

        [TestMethod]
        public void Should_return_Throw_Exception_When_A_Number_Superior_Than_4999_Is_Entered()
        {
            //Arrange
            int enterNumbre = 5000;
            TransformNumbers transform = new TransformNumbers();

            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => transform.DigitstoRomains(enterNumbre), "Please Enter a number inferior to 4999");
        }

        [TestMethod]
        public void Should_return_Throw_Exception_When_0_Is_Entered()
        {
            //Arrange
            int enterNumbre = 0;
            TransformNumbers transform = new TransformNumbers();

            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => transform.DigitstoRomains(enterNumbre), "Please Enter a number inferior to 4999 digits with 4 digits max");
        }
        #endregion Errors_Tests

        #region Tests_With_One_Digits
        [TestMethod]
        public void Should_return_I_when_1_is_entered()
        {
            //Arrange
            int enterNumbre = 1;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void Should_return_V_when_5_is_entered()
        {
            //Arrange
            int enterNumbre = 5;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("V", result);
        }

        #endregion Tests_With_One_Digits

        #region Tests_With_Two_Digits

        [TestMethod]
        public void Should_return_X_when_10_is_entered()
        {
            //Arrange
            int enterNumbre = 10;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("X", result);
        }

        [TestMethod]
        public void Should_return_XLVII_when_47_is_entered()
        {
            //Arrange
            int enterNumbre = 47;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("XLVII", result);
        }

        [TestMethod]
        public void Should_return_XCIX_when_99_is_entered()
        {
            //Arrange
            int enterNumbre = 99;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("XCIX", result);
        }
        #endregion Tests_With_Two_Digits

        #region Tests_With_Three_Digits
        [TestMethod]
        public void Should_return_CXII_when_112_is_entered()
        {
            //Arrange
            int enterNumbre = 112;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("CXII", result);
        }

        [TestMethod]
        public void Should_return_CII_when_102_is_entered()
        {
            //Arrange
            int enterNumbre = 102;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("CII", result);
        }

        [TestMethod]
        public void Should_return_CII_when_999_is_entered()
        {
            //Arrange
            int enterNumbre = 999;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("CMXCIX", result);
        }
        #endregion Tests_With_Three_Digits

        #region Tests_With_Four_Digits
        [TestMethod]
        public void Should_return_MMVIII_when_2008_is_entered()
        {
            //Arrange
            int enterNumbre = 2008;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("MMVIII", result);
        }

        [TestMethod]
        public void Should_return_MCMXC_when_1990_is_entered()
        {
            //Arrange
            int enterNumbre = 1990;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("MCMXC", result);
        }
        #endregion Tests_With_Four_Digits
    }
}