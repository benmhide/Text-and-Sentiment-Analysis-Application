using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMP1127M_PartB
{
    class TextCleaner                                               // Text cleaning class which has 5 custom method to clean (remove and replace characters) in a string.
    {
        public static string CleanedText(string textToAnalyse)      // Text cleaning method. Method takes one string agrument. Removes characters and substrings from a string and returns the cleaned string.
        {
            string textToAnalyseCleaned =                                                       // Passes the text to analyse to the RemoveURLs method of this Class and stores the result....
                RemoveURLs(textToAnalyse);                                                      // ....to textToAnalyseCleaned string.

            string textToAnalyseCharsRemoved =                                                  // Passes the cleaned text to analyse to the OnlyWordsString method of this Class and stores the....
                OnlyWordsString(textToAnalyseCleaned);                                          // ....result to textToAnalyseCharsRemoved string.

            string textToAnalyseCompCleaned =                                                   // Passes the text to analyse with characters removed to the ReduceWhiteSpace method of this Class.... 
                WhitespaceReducer.ReduceWhiteSpace(textToAnalyseCharsRemoved);                  // ....and stores the result to the textToAnalyseCompCleaned string.      

            return textToAnalyseCompCleaned;                                                    // Returns the textToAnalyseCompCleaned string.
        }

        public static string OnlyWordsString(string textToAnalyse)   // Unwanted character remover method. Method takes one string agrument. Removes/replaces unwanted characters in a string and returns the string. 
        {
            textToAnalyse = RemoveURLs(textToAnalyse);                                          // Takes the string and removes any urls using the removeURL method.

            char[] charToReplace = { '\n', '\r', '\t', '_', '-', ',', '"', '/', ':', '@' };     // Assigns a char array of characters to replace in a string.
            char charToRemove = '\'';                                                           // Assigns a char with a character to remove from a string.

            for (int i = 0; i < charToReplace.Length; i++)                                      // For loop which loops through each index of char array to replace the characters in the string.
            {
                textToAnalyse = textToAnalyse.Replace(charToReplace[i], ' ');                   // Replace each of the char array items in the string with a space character.
            }
            textToAnalyse = RemoveCharFromString(textToAnalyse, charToRemove);                  // Calls the RemoveCharFromString method and assigns the result to string.
            return textToAnalyse;                                                               // Returns the modified string.
        }

        public static string RemoveURLs(string textToAnalyse)                                   // URL remover method. Method takes one string agrument. Removes URLs in a string and returns the string....
        {                                                                                       // ....(using regular expressions engine). 
            string textToAnalyseRemovedURLs =
                Regex.Replace(textToAnalyse, @"http[^\s]+", "");                                // Using the regular expressions engine to match any string that starts with http/https and ends....
                                                                                                // ....in a space and replaces it with an empty string.

            return textToAnalyseRemovedURLs;                                                    // Returns the textToAnalyseRemovedURLs string.
        }

        public static string RemoveCharFromString(string textToAnaylse, char charToRemove)      // Character remover method. Method takes one string agrument. Removes unwanted characters in a string....
        {                                                                                       // ....and returns the string.  
              
            int indexOfChar = textToAnaylse.IndexOf(charToRemove);                              // Assigns an integer to the index of the first occurance of characters to remove in a string. 

            if (indexOfChar < 0)                                                                // If the index of the first occurance of a character is less than 0.....
            {
                return textToAnaylse;                                                           // Return the string as it is.
            }
            return RemoveCharFromString(textToAnaylse.Remove(indexOfChar, 1), charToRemove);    // Return the string string with characters removed.
        }
    }

    public static class WhitespaceReducer
    {
        public static string ReduceWhiteSpace(string textToAnalyse)             // White space remover method. Method takes one string agrument. Removes unwanted white space in a string and returns the string. 
        {
            var textWhiteSpaceReduced = new StringBuilder();                                    // Sets the textWhiteSpaceReduced as a new instance of the StringBuilder class.

            bool previousIsWhitespace = false;                                                  // Sets the boolean previousIsWhitespace to false.

            for (int i = 0; i < textToAnalyse.Length; i++)                                      // For loop which loops through each index of string length.
            {
                if (char.IsWhiteSpace(textToAnalyse[i]))                                        // If the character in the string is white space....
                {
                    if (previousIsWhitespace)                                                   // If the previous character is white space....
                    {
                        continue;                                                               // Continue the loop.
                    }
                    previousIsWhitespace = true;                                                // Sets the boolean previousIsWhitespace to true.     
                }
                else                                                                            // Else....
                {
                    previousIsWhitespace = false;                                               // Sets the boolean previousIsWhitespace to false.    
                }
                textWhiteSpaceReduced.Append(textToAnalyse[i]);                                 // Append the textWhiteSpaceReduced string with the textToAnalyse index.
            }
            return textWhiteSpaceReduced.ToString();                                            // Returns the converted and amended string builder as a string.
        }
    }
}

