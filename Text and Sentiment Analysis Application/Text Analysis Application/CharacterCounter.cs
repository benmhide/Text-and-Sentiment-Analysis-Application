using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1127M_PartB
{
    public class CharacterCounter                                                       // Character counting class with 7 custom methods for counting the different types of characters in a string.
    {
        public static int[] CharacterCount(string textToAnalyse)                        // Character counting method. Method takes one string agrument. Counts all types of characters in the....
                                                                                        // ....string and returns the count as an integer array.
        {
            int[] countCharacters = new int[7];                                                     // Integer array which stores the values of the character counts from the methods in this class.

            int countTotalCharacters = TotalCharacterCount(textToAnalyse);                          // Integer which stores the result of the total character count from the TotalCharacterCount method.

            int countVowel = VowelCount(textToAnalyse);                                             // Integer which stores the result of the vowel character count from the VowelCount method.

            int countConsonant = ConsonantCount(textToAnalyse, countVowel);                         // Integer which stores the result of the consonant character count from the ConsonanatCount method.

            int countNumber = NumberCount(textToAnalyse);                                           // Integer which stores the result of the number character count from the NumberCount method.

            int countSpaces = WhiteSpaceCount(textToAnalyse);                                       // Integer which stores the result of the space character count from the WhiteSpaceCount method.

            int totalCharsNoSpaces = (countTotalCharacters - countSpaces);                          // Integer which stores the result of the of the calculation of the total character value....
                                                                                                    // .... subtracting the space count value. 

            int notOtherChars = countConsonant + countVowel + countNumber;                          // Integer which stores the result of the of the sum of the consonant, vowel and number character values.  

            int countOtherCharacter = OtherCharacterCount(totalCharsNoSpaces, notOtherChars);       // Integer which stores the result of the other character count from the OtherCharacterCount method.


            countCharacters[0] = countVowel;                                            // Assigns the vowel character count value to the 1st index of the character count array.

            countCharacters[1] = countConsonant;                                        // Assigns the consonant character count value to the 2nd index of the character count array.

            countCharacters[2] = countSpaces;                                           // Assigns the space character count value to the 3rd index of the character count array.

            countCharacters[3] = countNumber;                                           // Assigns the number character count value to the 4th index of the character count array.

            countCharacters[4] = countOtherCharacter;                                   // Assigns the other character count value to the 5th index of the character count array.

            countCharacters[5] = countTotalCharacters;                                  // Assigns the total character count value to the 6th index of the character count array.

            countCharacters[6] = totalCharsNoSpaces;                                    // Assigns the total character without spaces count value to the 7th index of the character count array.

            return countCharacters;                                                     // Returns the character count array.
        }

        private static int TotalCharacterCount(string textToAnalyse)                    // Total character counting method. Method takes one string agrument. Counts the total characters....
        {                                                                               // ....in the string and returns the count as an integer.

            int countTotalCharacters = 0;                                               // Integer used to store the total character count value.

            for (int i = 0; i < textToAnalyse.Length; i++)                              // For loop which loops through each index of the string to count the characters.
            {
                if (textToAnalyse[i] == '\r'                                            // If the character is a carriage return character....
                    || textToAnalyse[i] == '\n'                                         // or a new line character....
                    || textToAnalyse[i] == '\t')                                        // or a tab character....
                {
                    continue;                                                           // continue the loop.
                }
                else
                {
                    countTotalCharacters++;                                             // Else if the index is another character add one to the countTotalCharacters value.
                }
            }
            return countTotalCharacters;                                                // Return the total charcter count.
        }

        private static int ConsonantCount(string textToAnalyse, int vowelCount)         // Consonant character counting method. Method takes 1 string and 1 integer agrument. 
        {                                                                               // Counts consonants in a string and returns the count as an integer. (Works with the VowelCount method in this class).

            int countConsonant = 0;                                                     // Integer used to store the consonant character count value.

            foreach (char character in textToAnalyse)                                   // Foreach character in the string....
            {
                if (char.IsLetter(character.ToString(), 0))                             // If the character in the string is a letter....
                {
                    countConsonant++;                                                   // Add one to the consonant count value.
                }
            }
            countConsonant -= vowelCount;                                               // At this point the countConsonant value is equal to the total letters in the string, removes the vowel....
                                                                                        // ....count value from the consonant count value.

            return countConsonant;                                                      // Return the consonant count value.
        }

        private static int VowelCount(string textToAnalyse)                             // Vowel character counting method. Method takes one string agrument. Counts the vowel characters in....
        {                                                                               // ....the string and returns the count as an integer.

            int countVowel = 0;                                                         // Integer used to store the total character count value.

            for (int i = 0; i < textToAnalyse.Length; i++)                              // For loop which loops through each index of the string to count the vowel characters.
            {
                if (textToAnalyse[i] == 'A'                                             // If the character is an A character....
                    || textToAnalyse[i] == 'E'                                          // or an E....
                    || textToAnalyse[i] == 'I'                                          // or an I....
                    || textToAnalyse[i] == 'O'                                          // or an O....
                    || textToAnalyse[i] == 'U'                                          // or a U....
                    || textToAnalyse[i] == 'a'                                          // or an a....
                    || textToAnalyse[i] == 'e'                                          // or an e....
                    || textToAnalyse[i] == 'i'                                          // or an i....
                    || textToAnalyse[i] == 'o'                                          // or an o....
                    || textToAnalyse[i] == 'u')                                         // or a u....
                {
                    countVowel++;                                                       // Add one to the vowel count value.
                }
            }
            return countVowel;                                                          // Return the vowel count value.
        }

        private static int NumberCount(string textToAnalyse)                            // Number character counting method. Method takes one string agrument. Counts the number characters....
        {                                                                               // ....in the string and returns the count as an integer.

            int countNumber = 0;                                                        // Integer used to store the number character count value.

            foreach (char character in textToAnalyse)                                   // Foreach character in the string....                               
            {
                if (char.IsDigit(character.ToString(), 0))                              // If the character is a digit....
                {
                    countNumber++;                                                      // Add one to the number count value.
                }
            }
            return countNumber;                                                         // Return the number count value.
        }

        private static int WhiteSpaceCount(string textToAnalyse)                        // Space character counting method. Method takes one string agrument. Counts the space characters....
        {                                                                               // ....in the string and returns the count as an integer.

            int countSpaces = 0;                                                        // Integer used to store the space character count value.

            for (int i = 0; i < textToAnalyse.Length; i++)                              // For loop which loops through each index of the string to count the the space characters.
            {
                if (textToAnalyse[i] == ' ')                                            // If the character is a space character....
                {
                    countSpaces++;                                                      // Add one to the space count value.
                }
            }
            return countSpaces;                                                         // Return the space count value.
        }

        private static int OtherCharacterCount(int totalChars, int notSpecialChars)     // Other character counting method. Method takes 2 integer agruments. Subtracts one integer from another and
        {                                                                               // .... returns the count as an integer.

            int countOtherCharacter = (totalChars - notSpecialChars);                   // Integer to store the other character count. Takes the total character count (without spaces) and....
                                                                                        // ....subtracts the consonants, vowels and numbers counts

            return countOtherCharacter;                                                 // Return the other character count value.
        }
    }
}