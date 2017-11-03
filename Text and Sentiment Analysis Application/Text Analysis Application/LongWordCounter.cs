using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMP1127M_PartB
{
    public class LongWordCounterAndFinder                                       // Long word counting class with 2 custom method for counting and finding words with 8 or more characters in a string.
    {
        public static string[] LongWordFinder(string[] textToAnalyseArray)      // Long word finder method. Method takes one string array agrument. Finds the words in the string with 8 or more letters....
        {                                                                       // ....and returns the words as an array.

            List<string> longWordsList = new List<string>();                    // Creates a new list.

            int wordLength = 8;                                                 // Integer used to store the word length value.

            for (int i = 0; i < textToAnalyseArray.Length; i++)                 // For loop which loops through each index of the array to find the long words.
            {
                if (textToAnalyseArray[i].Length >= wordLength)                 // If the text to analyse array word is greater than or equal to the word length....
                {
                    longWordsList.Add(textToAnalyseArray[i]);                   // Add the word to the long words list.
                }
            }
            string[] longWordsArray = longWordsList.ToArray();                  // Creates a new string array from the final long words list.

            return longWordsArray;                                              // Returns the long word string array.
        }

        public static int LongWordCounter(string textToAnalyse)                 // Long word counting method. Method takes one string agrument. Counts the words with 8 or more letters in the string....      
        {                                                                       // ....and returns the count as an integer. 

            MatchCollection longWords =                                         // Using the regular expressions engine to match any word with 8 or more characters.
                Regex.Matches(textToAnalyse, "[^ ]{8,}");

            return longWords.Count;                                             // Returns the long word count integer value.
        }
    }
}