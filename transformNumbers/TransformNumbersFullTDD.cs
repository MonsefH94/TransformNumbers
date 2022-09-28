using System;
using System.Collections.Generic;
using System.Text;

namespace transformNumbers
{
    public class TransformNumbersFullTDD
    {
        //TODO
        //Tuple<int, string> tDD = new Tuple<int, string>(0, "");

        Dictionary<int,string> Transform_numbers_To_Roman = new Dictionary<int,string>();
        Dictionary<string, int> Transform__To_Roman = new Dictionary<string, int>();

        public string DigitstoRomains(int digits_Entered_By_User)
        {
            switch (digits_Entered_By_User)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                    return Transform_Numbers_From_1_To_8(digits_Entered_By_User);
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
                case 19:               
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                    return Transform_Numbers_From_19_29(digits_Entered_By_User);
                case 29:
                case 30:
                case 31:
                case 32:
                case 33:
                case 34:
                case 35:
                case 36:
                case 37:
                case 38:
                    return Transform_Numbers_From_29_38(digits_Entered_By_User);

                default:
                    return string.Empty;
            }
        }

        public string Transform_Numbers_From_1_To_3(int digits_Entered_By_User)
        {
            StringBuilder result_in_romains = new StringBuilder();
            //TODO
            return result_in_romains.Insert(0,"I", digits_Entered_By_User).ToString();
        }

        public string Transform_Numbers_From_1_To_8(int digits_Entered_By_User)
        {
            StringBuilder result_in_romains = new StringBuilder();
            int rest_of_substitution = digits_Entered_By_User - 5;
            if (digits_Entered_By_User < 4)
            {
                return result_in_romains.Append(Transform_Numbers_From_1_To_3(digits_Entered_By_User)).ToString();
            }
            result_in_romains.Append("V");
            if (rest_of_substitution == -1)
            {
                return result_in_romains.Insert(0, "I").ToString();
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
            else
            {
                return result_in_romains.Append(Transform_Numbers_From_1_To_8(rest_of_substitution)).ToString();
            }
        }

        public string Transform_Numbers_From_19_29(int digits_Entered_By_User)
        {
            StringBuilder result_in_romains = new StringBuilder();
            result_in_romains.Append("XX");
            int rest_of_substitution = digits_Entered_By_User - 20;
            if (rest_of_substitution == -1)
            {
                return result_in_romains.Insert(1, "I").ToString();
            }
            else
            {
                return result_in_romains.Append(Transform_Numbers_From_1_To_8(rest_of_substitution)).ToString();
            }
        }

        public string Transform_Numbers_From_29_38(int digits_Entered_By_User)
        {
            StringBuilder result_in_romains = new StringBuilder();
            result_in_romains.Append("XXX");
            int rest_of_substitution = digits_Entered_By_User - 30;
            if (rest_of_substitution == -1)
            {
                return result_in_romains.Insert(2, "I").ToString();
            }
            else
            {
                return result_in_romains.Append(Transform_Numbers_From_1_To_8(rest_of_substitution)).ToString();
            }
        }
    }
}
