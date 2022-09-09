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
        private readonly Dictionary<int, int> dictionary_Coefficient_Digits = new Dictionary<int, int>();
        const int Number_Of_Digits_Equal_ONE = 1;
        const int Number_Of_Digits_Equal_TWO = 2;
        const int Number_Of_Digits_Equal_THREE = 3;
        const int Number_Of_Digits_Equal_FOUR = 4;
        private string result_Of_Transformation = string.Empty;

        private void FillDicotionary()
        {
            const int ONE_DIGIT_COEFFICIENT = 1;
            const int TWO_DIGITS_COEFFICIENT = 10;
            const int THREE_DIGITS_COEFFICIENT = 100;
            const int FOUR_DIGITS_COEFFICIENT = 1000;

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

            dictionary_Coefficient_Digits.Add(Number_Of_Digits_Equal_ONE, ONE_DIGIT_COEFFICIENT);
            dictionary_Coefficient_Digits.Add(Number_Of_Digits_Equal_TWO, TWO_DIGITS_COEFFICIENT);
            dictionary_Coefficient_Digits.Add(Number_Of_Digits_Equal_THREE, THREE_DIGITS_COEFFICIENT);
            dictionary_Coefficient_Digits.Add(Number_Of_Digits_Equal_FOUR, FOUR_DIGITS_COEFFICIENT);
        }

        public string DigitstoRomains(int digits_Entered_By_User)
        {

            const int Maximum_Number_That_Can_Be_Transformed = 4999;

            int Number_Of_Digits_entered = Get_Length_of_Number(digits_Entered_By_User);


            if (CheckKeyInDictionnary(digits_Entered_By_User))
            {
                return GetValuefromDictonnary(digits_Entered_By_User);
            }
            else
            {
                switch (Number_Of_Digits_entered)
                {
                    case Number_Of_Digits_Equal_TWO:
                    case Number_Of_Digits_Equal_THREE:
                        return Transform_Digits_To_Romains(digits_Entered_By_User);
                    case Number_Of_Digits_Equal_FOUR:
                        if (digits_Entered_By_User > Maximum_Number_That_Can_Be_Transformed)
                        {
                            throw new InvalidOperationException("Please Enter a number inferior to 4999");
                        }
                        return Transform_Digits_To_Romains(digits_Entered_By_User);

                    default:
                        throw new InvalidOperationException("Please Enter a number inferior to 4 digits");
                }
            }
        }

        public string GetValuefromDictonnary(int Number_dictionnary_key)
        {
            dictionary_Transform_Numbers.TryGetValue(Number_dictionnary_key, out string result_Of_Transformation_getted);
            return result_Of_Transformation_getted;
        }

        public Boolean CheckKeyInDictionnary(int Number_dictionnary_key)
        {
            return dictionary_Transform_Numbers.ContainsKey(Number_dictionnary_key);
        }

        public int Get_Length_of_Number(int Number_data_entrance)
        {
            return Number_data_entrance.ToString().Length;
        }

        public int Get_Coefficient_Digits(int digits_Entered_By_User)
        {
            dictionary_Coefficient_Digits.TryGetValue(Get_Length_of_Number(digits_Entered_By_User), out int coefficient_digits_transformation);
            return coefficient_digits_transformation;
        }

        public string Transform_Digits_To_Romains(int digits_Entered_By_User)
        {
            int Last_Digits_entered = digits_Entered_By_User % Get_Coefficient_Digits(digits_Entered_By_User);
            int first_Digit_entered = digits_Entered_By_User - Last_Digits_entered;

            result_Of_Transformation += GetValuefromDictonnary(first_Digit_entered);

            return CheckKeyInDictionnary(Last_Digits_entered) ? result_Of_Transformation += GetValuefromDictonnary(Last_Digits_entered) :  Transform_Digits_To_Romains(Last_Digits_entered);

        }
    }


}
