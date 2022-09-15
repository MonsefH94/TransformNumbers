using System;
using System.Collections.Generic;
using System.Text;

namespace transformNumbers
{
    public class TransformNumbersFullTDD
    {

        public string DigitstoRomains(int digits_Entered_By_User)
        {
            switch (digits_Entered_By_User)
            {
                case 1:
                case 2:
                case 3:
                    return Transform_Numbers_From_1_To_3(digits_Entered_By_User);
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    return Transform_Numbers_From_4_To_8(digits_Entered_By_User);
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    return Transform_Numbers_From_9_To_18(digits_Entered_By_User);

                default:
                    return string.Empty;
            }
        }

        public string Transform_Numbers_From_1_To_3(int digits_Entered_By_User)
        {
            StringBuilder result_in_romains = new StringBuilder();
            for (int i = 0; i < digits_Entered_By_User; i++)
            {
                result_in_romains.Append("I");
            }
            return result_in_romains.ToString();
        }

        public string Transform_Numbers_From_4_To_8(int digits_Entered_By_User)
        {
            StringBuilder result_in_romains = new StringBuilder();
            result_in_romains.Append("V");
            int rest_of_substitution = digits_Entered_By_User - 5;
            if (rest_of_substitution == -1)
            {
                return result_in_romains.Insert(0, "I").ToString();
            }
            else if (rest_of_substitution == 0)
            {
                return result_in_romains.ToString();
            }
            else
            {
                return result_in_romains.Append(Transform_Numbers_From_1_To_3(rest_of_substitution)).ToString();
            }
        }

        public string Transform_Numbers_From_9_To_18(int digits_Entered_By_User)
        {
            StringBuilder result_in_romains = new StringBuilder();
            result_in_romains.Append("X");
            int rest_of_substitution = digits_Entered_By_User - 10;
            if (rest_of_substitution == -1)
            {
                return result_in_romains.Insert(0, "I").ToString();
            }
            else if (rest_of_substitution == 0)
            {
                return result_in_romains.ToString();
            }
            else
            {
                return result_in_romains.Append(Transform_Numbers_From_4_To_8(rest_of_substitution)).ToString();
            }
        }
    }
}
