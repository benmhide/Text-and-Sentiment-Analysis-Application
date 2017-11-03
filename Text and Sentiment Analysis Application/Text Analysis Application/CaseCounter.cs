using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1127M_PartB
{
    public class CaseCounter                                            // Character case counting class with 2 custom methods for counting the different types of case characters in a string.
    {
        public static int UpperCaseCount(string textToAnalyse)          // Uppercase character counting method. Method takes 1 string agrument. Counts the uppercase letters in a string and....
        {                                                               // .... returns the count as an integer.

            int countUpper = 0;                                         // Integer used to store the uppercase character count value.

            for (int i = 0; i < textToAnalyse.Length; i++)              // For loop which loops through each index of the string to count the uppercase characters.
            {
                if (char.IsUpper(textToAnalyse[i]))                     // If the character in the string is an uppercase letter....
                {
                    countUpper++;                                       // ....add one to the countUpper value.
                }
            }
            return countUpper;                                          // Return the uppercase count value.
        }

        public static int LowerCaseCount(string textToAnalyse)          // Lowercase character counting method. Method takes 1 string agrument. Counts the lowercase letters in a string and....
        {                                                               // .... returns the count as an integer.

            int countLower = 0;                                         // Integer used to store the lowercase character count value.

            for (int i = 0; i < textToAnalyse.Length; i++)              // For loop which loops through each index of the string to count the lowercase characters.
            {
                if (char.IsLower(textToAnalyse[i]))                     // If the character in the string is an lowercase letter....       
                {
                    countLower++;                                       // ....add one to the countLower value.
                }
            }
            return countLower;                                          // Return the lowercase count value.
        }
    }
}
