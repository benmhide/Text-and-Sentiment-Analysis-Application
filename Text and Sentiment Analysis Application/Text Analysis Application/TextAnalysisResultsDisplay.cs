using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1127M_PartB
{
    class TextAnalysisResultsDisplay                                // Text Analysis Results Display class with a custom methods for displaying the results of the text analysis of a string to the console window.
    {
        static string spacer = "\n********************************************"
            + "******************************************************\n";                                       // String to store the spacer text.
        static string spacerNoEndNewLine = "\n*********************************"
            + "*****************************************************************";                              // String to store the spacer text (finishing without a new line).
        static string thereIsAre = "\n*************\t There is/are ";                                           // String to store repeatedly displayed console text.
        static string inThisText = "in this piece of text.";                                                    // String to store repeatedly displayed console text.
        static string negPercent = "\n*************\t The percentage of negative words in this text is: ";      // String to store repeatedly displayed console text.
        static string posPercent = "\n*************\t The percentage of positive words in this text is: ";      // String to store repeatedly displayed console text.


        public static void AnalysisResults                          // Console window display method. Method takes 8 agruments. Displays the results of the arguments to the console window. Returns void.
            (string textToAnalyse,                                  // 1 string, 3 string array, 1 integer array and 6 integer arguments are rquired.
            int[] countCharactersResult,                            // These arguments are either the results of the custom method calls from different custom classes.
            int wordCounterResult,                                  // These arguments store the results of the various text analysis procedures produced from either the default text file or user input text.
            int sentenceCounterResult,
            int paragraphCounterResult,         
            int upperCaseCounterResult,
            int lowerCaseCounterResult,
            int longWordsCountResult)
        {

            Console.Write("The text to be analysed is as follows: " + spacer + textToAnalyse + spacer + "\nPress enter to continue......." + spacer);   // Writes the text to the console window.
            Console.ReadLine();                                                                                                                         // Wait for user to press enter.

            Console.WriteLine                                                                                                                           // Writes the text to the console window.
                ("Text analysis results from this piece of text are as follows:" + spacer +                                                             // Shows the results of the text analysis form the....
                thereIsAre + wordCounterResult + " word(s) " + inThisText +                                                                             // ....analysed text.
                thereIsAre + sentenceCounterResult + " sentence(s) " + inThisText +                                                                     // Inculdes: word, sentence, paragraph and character counts.
                thereIsAre + paragraphCounterResult + " paragraph(s) " + inThisText +
                thereIsAre + countCharactersResult[0] + " vowel(s) " + inThisText +
                thereIsAre + countCharactersResult[1] + " consonant(s) " + inThisText +
                thereIsAre + countCharactersResult[2] + " space(s) " + inThisText +
                thereIsAre + countCharactersResult[3] + " number(s) " + inThisText +
                thereIsAre + countCharactersResult[4] + " other character(s) " + inThisText +
                thereIsAre + countCharactersResult[5] + " total character(s) (with spaces) " + inThisText +
                thereIsAre + countCharactersResult[6] + " total character(s) (without spaces) " + inThisText +
                thereIsAre + upperCaseCounterResult + " uppercase letter(s) " + inThisText +
                thereIsAre + lowerCaseCounterResult + " lowercase letter(s) " + inThisText +
                thereIsAre + longWordsCountResult + " word(s) with 8 or more letter(s) " + inThisText);

            Console.WriteLine("*************\t Every instance of a word with 8 or more characters has been written" +                                   // Writes the text to the console window.    
                "\n*************\t to the LongWords.txt (located in the debug file of this solution).");

            Console.WriteLine(spacer + "\nPress enter to continue......." + spacerNoEndNewLine);                                                        // Writes the text to the console window.
            Console.ReadLine();                                                                                                                         // Wait for user to press enter.

            Console.Write("The frequency of each alphanumeric character which appears in this piece of text is as follows:" + spacer);                  // Writes the text to the console window.

            CharacterFrequencyCounter.CountCharacterFrequency(textToAnalyse);                                                                           // Displays frequencies of the character in the analysed....
                                                                                                                                                        // ....text using the CountCharacterFrequency method from....
                                                                                                                                                        // ....the CharacterFrequencyCounter class.

            Console.WriteLine(spacer + "\nPress enter to continue......." + spacerNoEndNewLine);                                                        // Writes the text to the console window.
            Console.ReadLine();                                                                                                                         // Wait for user to press enter.
        }

        public static void SentimentAnalysisResults                 // Console window display method. Method takes 8 agruments. Displays the results of the arguments to the console window. Returns void.
            (string[] negativeWordsArray,                           // 1 string, 3 string array and 4 double arguments are rquired.
            string[] positiveWordsArray,                            // These arguments are either the results of the custom method calls from different custom classes.
            string[] textToAnalyseArray,                            // These arguments store the results of the various text analysis procedures produced from either the default text file or user input text.
            double positiveWordCounterResult,
            double negativeWordCounterResult,
            double negativeWordFrequency,
            double positiveWordFrequency,
            string sentimentResult)
        {
            Console.WriteLine("The positive word(s) which is/are present in the text is/are as follows:" + spacerNoEndNewLine);                         // Writes the text to the console window.

            SentimentAnalysis.PositiveWordDisplay(textToAnalyseArray, positiveWordsArray);                                                              // Displays positive words in the analysed text using the....
                                                                                                                                                        // ....PositiveWordDisplay method from the....
                                                                                                                                                        // ....SentimentAnalysis class.

            Console.WriteLine(spacer + "\nThe negative word(s) which is/are present in the text is/are as follows:" + spacerNoEndNewLine);              // Writes the text to the console window.

            SentimentAnalysis.NegativeWordDisplay(textToAnalyseArray, negativeWordsArray);                                                              // Displays negative words in the analysed text using the....
                                                                                                                                                        // ....NegativeWordDisplay method from the....
                                                                                                                                                        // ....SentimentAnalysis class.

            Console.WriteLine                                                                                                                           // Writes the text to the console window.
                (spacer + thereIsAre + positiveWordCounterResult + " occourances of positive word(s) " + inThisText +                                   // Shows the results of the sentiment analysis form the....
                thereIsAre + negativeWordCounterResult + " occourances of negative word(s) " + inThisText +                                             // ....analysed text.
                negPercent + negativeWordFrequency + "%" +                                                                                              // Inculdes: popsitive/negative word counts and....
                posPercent + positiveWordFrequency + "%" +                                                                                              // ....positive/negative word frequencies.
                "\n\nThe text may be considered " + sentimentResult);

            Console.WriteLine(spacer + "\nText analyse has finished. Press enter to continue....." + spacerNoEndNewLine);                               // Writes the text to the console window.
            Console.ReadLine();                                                                                                                         // Wait for user to press enter.

        }
    }
}
