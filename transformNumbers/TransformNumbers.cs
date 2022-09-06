using System;
using System.Collections.Generic;

namespace transformNumbers
{
    public class TransformNumbers
    {
        public TransformNumbers()
        {
            FillDicotionary();
        }

        private readonly Dictionary<int, string> dictionary_Transform_Numbers = new Dictionary<int, string>();

        private void FillDicotionary()
        {
            dictionary_Transform_Numbers.Add(1, "I");
            dictionary_Transform_Numbers.Add(2, "II");
            dictionary_Transform_Numbers.Add(3, "III");
            dictionary_Transform_Numbers.Add(4, "IV");
            dictionary_Transform_Numbers.Add(5, "V");
            dictionary_Transform_Numbers.Add(6, "VI");
            dictionary_Transform_Numbers.Add(7, "VII");
            dictionary_Transform_Numbers.Add(8, "VIII");
            dictionary_Transform_Numbers.Add(9, "IX");
            dictionary_Transform_Numbers.Add(10, "X");
            dictionary_Transform_Numbers.Add(20, "XX");
            dictionary_Transform_Numbers.Add(30, "XXX");
            dictionary_Transform_Numbers.Add(40, "XL");
            dictionary_Transform_Numbers.Add(50, "L");
            dictionary_Transform_Numbers.Add(60, "LX");
            dictionary_Transform_Numbers.Add(70, "LXX");
            dictionary_Transform_Numbers.Add(80, "LXXX");
            dictionary_Transform_Numbers.Add(90, "XC");
            dictionary_Transform_Numbers.Add(100, "C");
            dictionary_Transform_Numbers.Add(200, "CC");
            dictionary_Transform_Numbers.Add(300, "CCC");
            dictionary_Transform_Numbers.Add(400, "CD");
            dictionary_Transform_Numbers.Add(500, "D");
            dictionary_Transform_Numbers.Add(600, "DC");
            dictionary_Transform_Numbers.Add(700, "DCC");
            dictionary_Transform_Numbers.Add(800, "DCCC");
            dictionary_Transform_Numbers.Add(900, "CM");
            dictionary_Transform_Numbers.Add(1000, "M");
            dictionary_Transform_Numbers.Add(2000, "MM");
            dictionary_Transform_Numbers.Add(3000, "MMM");
            dictionary_Transform_Numbers.Add(4000, "MMMM");
        }

        public string DigitstoRomains(int digits_Entered_By_User)
        {
            const int Number_Of_Digits_Equal_ONE = 1;
            const int Number_Of_Digits_Equal_TWO = 2;
            const int Number_Of_Digits_Equal_THREE = 3;
            const int Number_Of_Digits_Equal_FOUR = 4;
            const int Maximum_Number_That_Can_Be_Transformed = 4999;

            int Number_Of_Digits_entered = digits_Entered_By_User.ToString().Length;

            if (CheckKeyInDictionnary(digits_Entered_By_User))
            {
                return GetValuefromDictonnary(digits_Entered_By_User);
            }
            else
            {
                switch (Number_Of_Digits_entered)
                {
                    case Number_Of_Digits_Equal_ONE:

                        return GetValuefromDictonnary(digits_Entered_By_User);

                    case Number_Of_Digits_Equal_TWO:

                        return TransformTwoDigits(digits_Entered_By_User);

                    case Number_Of_Digits_Equal_THREE:

                        return TransformThreeDigits(digits_Entered_By_User);

                    case Number_Of_Digits_Equal_FOUR:

                        if (digits_Entered_By_User > Maximum_Number_That_Can_Be_Transformed)
                        {
                            throw new InvalidOperationException("Please Enter a number inferior to 4999");
                        }
                        return TransformFourDigits(digits_Entered_By_User);

                    default:
                        throw new InvalidOperationException("Please Enter a number inferior to 4 digits");
                }
            }
        }

        public string GetValuefromDictonnary(int Number)
        {
            dictionary_Transform_Numbers.TryGetValue(Number, out string result_Of_Transformation);
            return result_Of_Transformation;
        }

        public Boolean CheckKeyInDictionnary(int Number)
        {
            return dictionary_Transform_Numbers.ContainsKey(Number);
        }

        public string TransformTwoDigits(int digits_Entered_By_User)
        {
            string result_Of_Transformation_Two_Digits = string.Empty;
            const int TWO_DIGITS_COEFFICIENT = 10;
            int first_Digit_entered = digits_Entered_By_User / TWO_DIGITS_COEFFICIENT;
            int Last_Digits_entered = digits_Entered_By_User % TWO_DIGITS_COEFFICIENT;

            result_Of_Transformation_Two_Digits = GetValuefromDictonnary(first_Digit_entered * TWO_DIGITS_COEFFICIENT);
            return result_Of_Transformation_Two_Digits += GetValuefromDictonnary(Last_Digits_entered);
        }

        public string TransformThreeDigits(int digits_Entered_By_User)
        {
            string result_Of_Transformation_Three_Digits = string.Empty;
            const int THREE_DIGITS_COEFFICIENT = 100;
            int first_Digit_entered = digits_Entered_By_User / THREE_DIGITS_COEFFICIENT;
            int Last_Digits_entered = digits_Entered_By_User % THREE_DIGITS_COEFFICIENT;
            result_Of_Transformation_Three_Digits = GetValuefromDictonnary(first_Digit_entered * THREE_DIGITS_COEFFICIENT);
            return result_Of_Transformation_Three_Digits += TransformTwoDigits(Last_Digits_entered);
        }

        public string TransformFourDigits(int digits_Entered_By_User)
        {
            string result_Of_Transformation_Four_Digits = string.Empty;
            const int FOUR_DIGITS_COEFFICIENT = 1000;
            int first_Digit_entered = digits_Entered_By_User / FOUR_DIGITS_COEFFICIENT;
            int Last_Digits_entered = digits_Entered_By_User % FOUR_DIGITS_COEFFICIENT;

            result_Of_Transformation_Four_Digits = GetValuefromDictonnary(first_Digit_entered * FOUR_DIGITS_COEFFICIENT);
            return result_Of_Transformation_Four_Digits += TransformThreeDigits(Last_Digits_entered);
        }
    }

}
