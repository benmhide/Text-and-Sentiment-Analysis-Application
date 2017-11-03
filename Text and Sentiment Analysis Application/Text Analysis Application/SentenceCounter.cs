using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1127M_PartB
{
    public class SentenceCounter                                    // Sentence counting class which has a custom method to count the sentences in a string.
    {
        public static int CountFullStops(string textToAnalyse)      // Sentence counting method. Method takes one string agrument. Counts the words in the string and returns the count as an integer.
        {
            int countSentence = 0;                                  // Integer used to store the sentence count value.
            bool preivousIsSentenceEndChar = false;                 // Boolean to store if the last character index of the string is a sentence ending character.

            for (int i = 0; i < textToAnalyse.Length; i++)          // For loop which loops through the each index of a string.
            {
                if (textToAnalyse[i] == '.'                         // If the the index of the textToAnalsye string is a . or ! or ? ....
                    || textToAnalyse[i] == '!'
                    || textToAnalyse[i] == '?')
                {
                    if (preivousIsSentenceEndChar == false)         // If the previous index is not a sentence ending character....
                    {
                        countSentence++;                            // Add one to the sentence count value.
                    }
                    preivousIsSentenceEndChar = true;               // The last chacacter was a sentence ending character. Set boolean preivousIsSentenceEndChar to true.
                }
                else
                {
                    preivousIsSentenceEndChar = false;              // Else set boolean preivousIsSentenceEndChar to false.
                }
                continue;                                           // Continue the for loop.
            }
            return countSentence;                                   // Return the sentence count.
        }
    }
}


