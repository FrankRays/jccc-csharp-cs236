using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneWordCombinations
{
    class WordGen
    {
        private static string[,] OPTION =
        { 
            { "0", "0", "0" }, // 0 (not allowed) 
            { "1", "1", "1" }, // 1 (not allowed)
            { "A", "B", "C" }, // 2 
            { "D", "E", "F" }, // 3 
            { "G", "H", "I" }, // 4
            { "J", "K", "L" }, // 5 
            { "M", "N", "O" }, // 6 
            { "P", "R", "S" }, // 7 
            { "T", "U", "V" }, // 8 
            { "W", "X", "Y" }, // 9
        };

        private static string AddCombinations(int len, int[] digitArray)
        {
            string tempString = "";

            // If the array is equal to 1
            if (len == 1)
            {
                // print out the three letters for that letter.
                for (int j = 0; j < 3; j++)
                {
                    tempString += OPTION[digitArray[0], j];
                    tempString += Environment.NewLine; // Append the '\n' at the end.
                }

                return tempString;
            }

            if (len == 2)
            {
                for (int k = 0; k < 3; k++)
                {
                    for (int m = 0; m < 3; m++)
                    {
                        tempString += OPTION[digitArray[0], k] + OPTION[digitArray[1], m];
                        tempString += Environment.NewLine;
                    }
                }

                return tempString;
            }

            if (len == 3)
            {
                for (int n = 0; n < 3; n++)
                {
                    for (int num5 = 0; num5 < 3; num5++)
                    {
                        for (int num6 = 0; num6 < 3; num6++)
                        {
                            tempString += OPTION[digitArray[0], n] + OPTION[digitArray[1], num5] + OPTION[digitArray[2], num6];
                            tempString += Environment.NewLine;
                        }
                    }
                }

                return tempString;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int num8 = 0; num8 < 3; num8++)
                {
                    for (int num9 = 0; num9 < 3; num9++)
                    {
                        for (int num10 = 0; num10 < 3; num10++)
                        {
                            tempString += OPTION[digitArray[0], i] + OPTION[digitArray[1], num8] + OPTION[digitArray[2], num9] + OPTION[digitArray[3], num10];
                            tempString += Environment.NewLine;
                        }
                    }
                }
            }

            return tempString;
        }

        public static string CalculatePossibleWords(string phoneString)
        {
            int length = phoneString.Length;

            int[] digitArray = ConvertPhoneStringToIntArray(phoneString);

            return AddCombinations(length, digitArray);
        }

        private static int[] ConvertPhoneStringToIntArray(string phoneString)
        {
            int phoneNumber = Convert.ToInt32(phoneString);
            int[] digits = new int[4];

            for (int i = phoneString.Length - 1; i >= 0; i--)
            {
                digits[i] = (int)(phoneNumber % 10);
                phoneNumber /= 10;
            }

            return digits;
        }
    }
}
