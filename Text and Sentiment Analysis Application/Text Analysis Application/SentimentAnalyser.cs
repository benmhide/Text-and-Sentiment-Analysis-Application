using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1127M_PartB
{
    public class SentimentAnalysis                                                                          // Sentiment Analysis class with 7 custom methods for analysing the sentiment of a string.
    {
        public static void NegativeWordDisplay(string[] textToAnalyseArray, string[] negativeWordsArray)    // Negative words display method. Method takes 2 string array agruments.....
        {                                                                                                   // ....compares the 2 arrays and displays negative word matches from the 2 arrays. 

            var negativeWordsList = new List<string>(negativeWordsArray);                                   // Creates a new list from the negative words array.

            foreach (var negativeWords in negativeWordsList)                                                // Foreach negative word in the negative words list....
            {
                if (textToAnalyseArray.Contains(negativeWords))                                             // If the text to analyse contains a negative word from the negative word list....
                {
                    Console.WriteLine(negativeWords);                                                       // Write the word to the console window.                                                       
                }
            }
        }

        public static void PositiveWordDisplay(string[] textToAnalyseArray, string[] positiveWordsArray)    // Positive words display method. Method takes 2 string array agruments.....
        {                                                                                                   // ....compares the 2 arrays and displays positive word matches from the 2 arrays.

            var positiveWordsList = new List<string>(positiveWordsArray);                                   // Creates a new list from the positive words array.                              

            foreach (var positiveWords in positiveWordsList)                                                // Foreach positive word in the positive words list....
            {
                if (textToAnalyseArray.Contains(positiveWords))                                             // If the text to analyse contains a positive word from the positive word list....
                {
                    Console.WriteLine(positiveWords);                                                       // Write the word to the console window. 
                }
            }
        }

        public static double AnalyseSentimentNegative(string[] textToAnalyseArray, string[] negativeWordsArray)     // Negative words counting method. Method takes 2 string array agruments.....
        {                                                                                                           // ....compares the 2 arrays and counts negative word matches from the 2 arrays.

            double negativeWordCount = 0;                                                                           // Double used to store the negative word count value.

            var negativeWordsList = new List<string>(negativeWordsArray);                                           // Creates a new list from the negative words array.

            for (int i = 0; i < textToAnalyseArray.Length; i++)                                                     // For loop which loops through each index of the array to count the negative words.
            {
                if (negativeWordsList.Contains(textToAnalyseArray[i], StringComparer.OrdinalIgnoreCase))            // If the text to analyse contains a negative word from the negative word list....
                {
                    negativeWordCount++;                                                                            // ....add one to the negativeWordCount value.
                }
            }
            return negativeWordCount;                                                                               // Return the negative word count value.
        }

        public static double AnalyseSentimentPositive(string[] textToAnalyseArray, string[] positiveWordsArray)     // Positive words counting method. Method takes 2 string array agruments.....
        {                                                                                                           // ....compares the 2 arrays and counts positive word matches from the 2 arrays.

            double positiveWordCount = 0;                                                                           // Double used to store the positive word count value.

            var positiveWordsList = new List<string>(positiveWordsArray);                                           // Creates a new list from the positive words array.

            for (int i = 0; i < textToAnalyseArray.Length; i++)                                                     // For loop which loops through each index of the array to count the positive words.
            {
                if (positiveWordsList.Contains(textToAnalyseArray[i], StringComparer.OrdinalIgnoreCase))            // If the text to analyse contains a positive word from the positive word list....
                {
                    positiveWordCount++;                                                                            // ....add one to the positiveWordCount value.
                }
            }
            return positiveWordCount;                                                                               // Return the positive word count value.
        }

        public static double PositiveWordFrequencies                                                                // Positive words frequency method. Method takes 2 string array agruments.....
            (string[] textToAnalyseArray,                                                                           // .... and a double and integer arguent. Returns the percentage of positive words in the string.
            string[] positiveWordsArray,
            double positiveWordCounterResult,
            int wordCounterResult)
        {
            double positiveWordFrequency = 
                (AnalyseSentimentPositive(textToAnalyseArray, positiveWordsArray) / wordCounterResult) * 100d;      // Divide the result of the AnalyseSentimentPositive by the wordCounterResult, multiply by 100.

            positiveWordFrequency = Math.Truncate(positiveWordFrequency * 100d) / 100d;                             // Round off the result.

            return positiveWordFrequency;                                                                           // Return the positiveWordFrequency.
        }

        public static double NegativeWordFrequencies                                                                // Negative words frequency method. Method takes 2 string array agruments.....
            (string[] textToAnalyseArray,                                                                           // .... and a double and integer arguent. Returns the percentage of negative words in the string.
            string[] negativeWordsArray,
            double negativeWordCounterResult,
            int wordCounterResult)
        {
            double negativeWordFrequency = 
                (AnalyseSentimentPositive(textToAnalyseArray, negativeWordsArray) / wordCounterResult) * 100d;      // Divide the result of the AnalyseSentimentPositive by the wordCounterResult, multiply by 100.

            negativeWordFrequency = Math.Truncate(negativeWordFrequency * 100d) / 100d;                             // Round off the result.

            return negativeWordFrequency;                                                                           // Return the negativeWordFrequency.
        }

        public static string Sentiment(double positiveWordFrequency, double negativeWordFrequency)                  // Sentiment display method. Method takes 2 double arguments. Returns the sentiment of the string.
        {
            string sentimentResult = "un-biased. The text is generally balanced, neither negatively or positively biased.";         // Sets the sentimentResult defualt value.

            if (positiveWordFrequency > negativeWordFrequency)                                                                      // If the positiveWordFrequency is greater than the negativeWordFrequency....
            {
                sentimentResult = "positive. Or else the text may discuss, refer to or comment on positive issues or topics.";      // ....set the sentimentResult to the positive responce value.
            }
            else if (positiveWordFrequency < negativeWordFrequency)                                                                 // If the positiveWordFrequency is less than the negativeWordFrequency....
            {
                sentimentResult = "negative. Or else the text may discuss, refer to or comment on negative issues or topics.";      // ....set the sentimentResult to the negative responce value.
            }
            else if (positiveWordFrequency == negativeWordFrequency)                                                                // Else if the positiveWordFrequency nad negativeWordFrequency are equal....
            {
                return sentimentResult;                                                                                             // Return the sentimentResult defualt value.
            }
            return sentimentResult;                                                                                                 // Return the sentimentResult value.
        }
    }
}
