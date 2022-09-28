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
        private TransformNumbersFullTDD transform;

        [TestInitialize]
        public void TestInitialize()
        {
            transform = new TransformNumbersFullTDD();
        }

        [DataTestMethod]
        [DynamicData(nameof(MyArabicRomanTestcases))]
        public void Should_return_correct_roman_number_when_given_arabic_integer(int arabic, string expectedRoman)
        {
            //Act
            string actualRoman = transform.DigitstoRomains(arabic);

            //Assert
            Assert.AreEqual(expectedRoman, actualRoman);
        }

        public static IEnumerable<object[]> MyArabicRomanTestcases
        {
            get
            {
                yield return new object[] { 1, "I" };
                yield return new object[] { 2, "II" };
                yield return new object[] { 3, "III" };
                yield return new object[] { 4, "IV" };
                yield return new object[] { 5, "V" };
                yield return new object[] { 6, "VI" };
                yield return new object[] { 7, "VII" };
                yield return new object[] { 8, "VIII" };
                yield return new object[] { 9, "IX" };
                yield return new object[] { 10, "X" };
                yield return new object[] { 11, "XI" };
                yield return new object[] { 12, "XII" };
                yield return new object[] { 13, "XIII" };
                yield return new object[] { 14, "XIV" };
                yield return new object[] { 15, "XV" };
                yield return new object[] { 16, "XVI" };
                yield return new object[] { 17, "XVII" };
                yield return new object[] { 18, "XVIII" };
                yield return new object[] { 19, "XIX" };
                yield return new object[] { 20, "XX" };
                yield return new object[] { 21, "XXI" };
                yield return new object[] { 22, "XXII" };
                yield return new object[] { 23, "XXIII" };
                yield return new object[] { 24, "XXIV" };
                yield return new object[] { 25, "XXV" };
                yield return new object[] { 26, "XXVI" };
                yield return new object[] { 27, "XXVII" };
                yield return new object[] { 28, "XXVIII" };
                yield return new object[] { 29, "XXIX" };
                yield return new object[] { 30, "XXX" };
                yield return new object[] { 31, "XXXI" };
                yield return new object[] { 32, "XXXII" };
                yield return new object[] { 33, "XXXIII" };
                yield return new object[] { 34, "XXXIV" };
                yield return new object[] { 35, "XXXV" };
                yield return new object[] { 36, "XXXVI" };
                yield return new object[] { 37, "XXXVII" };
                yield return new object[] { 38, "XXXVIII" };
            }
        }
    }
}
