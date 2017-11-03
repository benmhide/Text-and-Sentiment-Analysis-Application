using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace CMP1127M_PartB
{
    class CharacterRemover
    {
        //public static string OnlyWordsString(string textToAnalyse)                              // Unwanted character remover method. Method takes one string agrument. Removes/replaces unwanted characters in a string and returns the string. 
        //{
        //    textToAnalyse = URLRemover.RemoveURLs(textToAnalyse);                               // Takes the string and removes any urls using the removeURL method for the URLRemover class.

        //    char[] charToReplace = { '\n', '\r', '\t', '_', '-', ',', '"', '/', ':', '@' };     // Assigns a char array of characters to replace in a string.
        //    char charToRemove = '\'';                                                           // Assigns a char with a character to remove from a string.

        //    for (int i = 0; i < charToReplace.Length; i++)                                      // For loop which loops through each index of char array to replace the characters in the string.
        //    {
        //        textToAnalyse = textToAnalyse.Replace(charToReplace[i], ' ');                   // Replace each of the char array items in the string with a space character.
        //    }
        //    textToAnalyse = RemoveCharFromString(textToAnalyse, charToRemove);                  // Calls the RemoveCharFromString method and assigns the result to string.
        //    return textToAnalyse;                                                               // Returns the modified string.
        //}


        //public static string RemoveCharFromString(string textToAnaylse, char charToRemove)
        //{
        //    int indexOfChar = textToAnaylse.IndexOf(charToRemove);
        //    if (indexOfChar < 0)
        //    {
        //        return textToAnaylse;
        //    }
        //    return RemoveCharFromString(textToAnaylse.Remove(indexOfChar, 1), charToRemove);
        //}
    }
}