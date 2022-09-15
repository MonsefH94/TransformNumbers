using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transformNumbers;

namespace TransformNumbersTests
{
    [TestClass]
    public class TransformNumbersFullTDDTests
    {
        #region Tests_With_One_Digits
        [TestMethod]
        public void Should_return_I_when_1_is_entered()
        {
            //Arrange
            int enterNumbre = 1;
            TransformNumbersFullTDD transform = new TransformNumbersFullTDD();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("I", result);
        }

        [TestMethod]
        public void Should_return_II_when_2_is_entered()
        {
            //Arrange
            int enterNumbre = 2;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("II", result);
        }

        [TestMethod]
        public void Should_return_III_when_3_is_entered()
        {
            //Arrange
            int enterNumbre = 3;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("III", result);
        }

        [TestMethod]
        public void Should_return_IV_when_3_is_entered()
        {
            //Arrange
            int enterNumbre = 4;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("IV", result);
        }

        [TestMethod]
        public void Should_return_V_when_3_is_entered()
        {
            //Arrange
            int enterNumbre = 5;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("V", result);
        }

        [TestMethod]
        public void Should_return_VI_when_6_is_entered()
        {
            //Arrange
            int enterNumbre = 6;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("VI", result);
        }

        [TestMethod]
        public void Should_return_VII_when_7_is_entered()
        {
            //Arrange
            int enterNumbre = 7;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("VII", result);
        }

        [TestMethod]
        public void Should_return_VIII_when_8_is_entered()
        {
            //Arrange
            int enterNumbre = 8;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("VIII", result);
        }

        [TestMethod]
        public void Should_return_IX_when_9_is_entered()
        {
            //Arrange
            int enterNumbre = 9;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("IX", result);
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
        public void Should_return_XI_when_11_is_entered()
        {
            //Arrange
            int enterNumbre = 11;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("XI", result);
        }

        [TestMethod]
        public void Should_return_XI_when_12_is_entered()
        {
            //Arrange
            int enterNumbre = 12;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("XII", result);
        }

        [TestMethod]
        public void Should_return_XII_when_13_is_entered()
        {
            //Arrange
            int enterNumbre = 13;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("XIII", result);
        }

        [TestMethod]
        public void Should_return_XIV_when_14_is_entered()
        {
            //Arrange
            int enterNumbre = 14;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("XIV", result);
        }

        [TestMethod]
        public void Should_return_XV_when_15_is_entered()
        {
            //Arrange
            int enterNumbre = 15;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("XV", result);
        }

        [TestMethod]
        public void Should_return_XVI_when_16_is_entered()
        {
            //Arrange
            int enterNumbre = 16;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("XVI", result);
        }

        [TestMethod]
        public void Should_return_XVII_when_17_is_entered()
        {
            //Arrange
            int enterNumbre = 17;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("XVII", result);
        }

        [TestMethod]
        public void Should_return_XVIII_when_18_is_entered()
        {
            //Arrange
            int enterNumbre = 18;
            TransformNumbers transform = new TransformNumbers();

            //Act
            string result = transform.DigitstoRomains(enterNumbre);

            //Assert
            Assert.AreEqual("XVIII", result);
        }
        #endregion Tests_With_Two_Digits
    }
}
