using System;
using System.IO;

/* Text Analysis console application. This application will analyse text and return counts and results based on the text which has been analysed.
 * There are two options for the text analysis: Analyse the defualt file inculded or analyse text input from the console window (from the user).
 * 
 * Created by Ben Hide for the CMP1127M_PartB assesment item of the Programming and Data Structures Module for the Games Computing Bsc (1st Year).*/


namespace CMP1127M_PartB
{
    class Program                                                                           // Main Program Class. The Program Class is where the user inface exsists and the reuslts of the analysis are displayed.
    {
        static string defualtTextFileName = "TextDocument.txt";                                                         // String to store the default text file name value.
        static string defualtTextFile = Path.Combine(Environment.CurrentDirectory, defualtTextFileName);                // String to store the default text file path value.

        static string userTextFileName = "UserTextDocument.txt";                                                        // String to store the user text file name value.
        static string userTextFile = Path.Combine(Environment.CurrentDirectory, userTextFileName);                      // String to store the user text file path value.  

        public static string negativeWordsFileName = "NegativeWords.txt";                                               // String to store the negative words text file name value.
        public static string negativeWordsFile = Path.Combine(Environment.CurrentDirectory, negativeWordsFileName);     // String to store the negative words file path value.
        public static string[] negativeWordsArray = File.ReadAllLines(negativeWordsFile);                               // String array to stores all the words from the negative words file.

        public static string positiveWordsFileName = "PositiveWords.txt";                                               // String to store the positive words text file name value.
        public static string positiveWordsFile = Path.Combine(Environment.CurrentDirectory, positiveWordsFileName);     // String to store the positive words file path value.
        public static string[] positiveWordsArray = File.ReadAllLines(positiveWordsFile);                               // String array to stores all the words from the positive words file.

        static string longWordsFileName = "LongWords.txt";                                                              // String to store the long words text file name value.
        static string longWordsFile = Path.Combine(Environment.CurrentDirectory, longWordsFileName);                    // String to store the long words file path value.


        public static void Main(string[] args)                                                              // Text analysis console application main method.
        {
            #region Main Method Variables - Used For Primary Program Class Functionality
            string textToAnalyse = "";                                                                      // String to store the text which is to be analysed.
            string userTextInput = "";                                                                      // String to store the user input text.

            bool optionSelected = false;                                                                    // Boolean to store the option selected value.
            bool repeatProgram = true;                                                                      // Boolean to store the repeat program value.
            bool continueOptionSelection = false;                                                           // Boolean to store the continue option selection value.

            string spacer = "\n********************************************" 
                + "******************************************************\n";                               // String to store the spacer text.
            string spacerNoEndNewLine = "\n*********************************"
                + "*****************************************************************";                      // String to store the spacer text (finishing without a new line).
            #endregion

            #region Start Of The Text Analysis Console Program
            Console.Write                                                                                                           // Writes the text to the console window.
                (spacer + "************************* WELCOME TO THE TEXT ANALYSIS CONSOLE PROGRAM ***************************" +
                spacer + "This program will analyse text and return information regarding ceratin aspects of the input text." +
                spacer);

            while (repeatProgram == true)                                                                                           // While repeat the program option is true....
            {
                File.WriteAllText(userTextFile, textToAnalyse);                                                                     // Cleans out the user text file of all text.
                File.WriteAllText(longWordsFile, textToAnalyse);                                                                    // Cleans out the long words text file of all text.

                Console.WriteLine                                                                                                   // Writes the text to the console window.
                    ("\nThere are two options available, the options are:" +
                    "\nOption 1 - User input text analysis (text input from the console window will be analysed)." + 
                    "\nOption 2 - Default input text analysis (text from the default text file will be analysed)." +
                    spacer + "\nWould you like to use Option 1 or Option 2 - enter 1 or 2 and press enter.\n");
                #endregion

                #region User Options Selection For Text Analysis Functionality
                while (optionSelected == false)                                                                                     // While loop option selected is false....
                {
                    Console.Write("Option: ");                                                                                      // Writes the text to the console window. 
                    string analyseOption = Console.ReadLine();                                                                      // String to store the analyse option selected by the user.

                    if (analyseOption == "1")                                                                                       // If option 1 is selected....
                    {
                        optionSelected = true;                                                                                      // Option selected is true.

                        Console.WriteLine                                                                                           // Writes the text to the console window.
                            (spacer + "\nOption 1 has been selected.\nYou have selected to enter your own text to be analysed." + 
                            "\nPlease enter your text below when prompted.\nTo finish text input on a new line input * and then press enter." +
                            spacer + "\nPlease input your text to be analysed now:");

                        while (true)                                                                                                // While loop infinately....
                        {
                            userTextInput = Console.ReadLine();                                                                     // Read the user text input from the console and pass to userTextInput.
                            userTextInput += "\n";                                                                                  // Amend userTextInput each time a new line is started with a new line character. 

                            File.AppendAllText(userTextFile, userTextInput);                                                        // Append the userTextFile with the user text input.

                            textToAnalyse = File.ReadAllText(userTextFile);                                                         // Read all the text from the user text file to textToAnalyse. 

                            if (userTextInput == "*\n")                                                                             // If the user text input is a * followed by return....
                            {
                                if (userTextInput.Length == 2)                                                                      // If the length of the userTextInput is 2.... 
                                {
                                    textToAnalyse = textToAnalyse.Remove(textToAnalyse.Length - 2);                                 // ....remove the last 2 charcaters of the string.
                                }
                                else if (userTextInput.Length > 2)                                                                  // If the length of the userTextInput is greater than 2... 
                                {
                                    textToAnalyse = textToAnalyse.Remove(textToAnalyse.Length - 3);                                 // ....remove the last 3 charcaters of the string.
                                }
                                break;                                                                                              // Break out of the loop.
                            }
                        }
                    }
                    else if (analyseOption == "2")                                                                                  // If option 2 is selected....
                    {
                        optionSelected = true;                                                                                      // Option selected is true.

                        Console.WriteLine                                                                                           // Writes the text to the console window.
                            (spacer + "\nOption 2 has been selected.\nYou have selected the default text file to be analysed." +    
                            "\nPress enter to continue and to see the results........" + spacerNoEndNewLine);
                        Console.ReadLine();                                                                                         // Wait for user to press enter.

                        textToAnalyse = File.ReadAllText(defualtTextFile);                                                          // Read all the text from the user text file to textToAnalyse.
                    }
                    else                                                                                                            // Else....
                    {
                        Console.WriteLine(spacer + "\nYou have not entered a valid response. Please try again." + spacer);          // Writes the text to the console window.
                    }
                }
                #endregion

                #region Variable Assignment For Text Analysis From Custom Class Method Calls 
                string textToAnalyseCompCleaned = TextCleaner.CleanedText(textToAnalyse);                               // Passes the text to analyse to the CleanText method of the TextCleaner Class....
                                                                                                                        // ....and stores the result to textToAnalyseCompletelyCleaned string.

                string[] textToAnalyseArray = StringToStringArrayConverter.ConvertedArray(textToAnalyseCompCleaned);    // Passes the cleaned text to analyse to the ConvertedArray method of the....
                                                                                                                        // ....StringToStringArrayConverter Class and stores the result to textToAnalyseArray array.

                int[] countCharactersResult = CharacterCounter.CharacterCount(textToAnalyse);                           // Passes the text to analyse to the CharacterCount method of the CharacterCounter Class.... 
                                                                                                                        // ....and stores the result to countCharactersResult array.

                int upperCaseCounterResult = CaseCounter.UpperCaseCount(textToAnalyse);                                 // Passes the text to analyse to the UpperCaseCount method of the CaseCounter Class....
                                                                                                                        // ....and stores the result to upperCaseCounterResult integer.

                int lowerCaseCounterResult = CaseCounter.LowerCaseCount(textToAnalyse);                                 // Passes the text to analyse to the LowerCaseCount method of the CaseCounter Class....
                                                                                                                        // ....and stores the result to lowerCaseCounterResult integer.

                int wordCounterResult = WordCounter.WordCount(textToAnalyse);                                           // Passes the text to analyse to the WordCount method of the WordCounter Class....
                                                                                                                        // ....and stores the result to wordCounterResult integer.

                int sentenceCounterResult = SentenceCounter.CountFullStops(textToAnalyseCompCleaned);                   // Passes the text to analyse to the CountFullStops method of the SentenceCounter Class....
                                                                                                                        // ....and stores the result to sentenceCounterResult integer.

                int paragraphCounterResult = ParagraphCounter.CountPrargraphs(textToAnalyse);                           // Passes the text to analyse to the CountPrargraphs method of the ParagraphCounter Class....
                                                                                                                        // ....and stores the result to paragraphCounterResult integer.

                double positiveWordCounterResult = SentimentAnalysis.AnalyseSentimentPositive(                          // Passes the text to analyse and the positive word array to the AnalyseSentimentPositive....
                        textToAnalyseArray, positiveWordsArray);                                                        // ....method of the SentimentAnalysis Class and stores the result to....
                                                                                                                        // ....positiveWordCounterResult double.

                double negativeWordCounterResult = SentimentAnalysis.AnalyseSentimentNegative(                          // Passes the text to analyse and the negative word array to the AnalyseSentimentNegative....
                        textToAnalyseArray, negativeWordsArray);                                                        // ....method of the SentimentAnalysis Class and stores the result to....
                                                                                                                        // ....negativeWordCounterResult double.

                double positiveWordFrequency =SentimentAnalysis.PositiveWordFrequencies(                                // Passes the text to analyse array, positive words array the positive word count and.... 
                        textToAnalyseArray, positiveWordsArray, positiveWordCounterResult, wordCounterResult);          // ....the word count to the PositiveWordFrequencies method of the SentimentAnalysis Class....
                                                                                                                        // ....and stores the result to the positiveWordFrequency double.

                double negativeWordFrequency = SentimentAnalysis.NegativeWordFrequencies(                               // Passes the text to analyse array, negative words array the positive word count and.... 
                        textToAnalyseArray, negativeWordsArray, negativeWordCounterResult, wordCounterResult);          // ....the word count to the NegativeWordFrequencies method of the SentimentAnalysis Class....
                                                                                                                        // ....and stores the result to the negativeWordFrequency double.

                string sentimentResult = SentimentAnalysis.Sentiment(positiveWordFrequency, negativeWordFrequency);     // Passes the negative word frequency and positive word frequency to the Sentiment method....
                                                                                                                        // ....of the SentimentAnalysis Class and stores the result to the sentimentResult string.

                int longWordsCountResult = LongWordCounterAndFinder.LongWordCounter(textToAnalyseCompCleaned);          // Passes the cleaned text to analyse to the LongWordCounter method of the 
                                                                                                                        // ..LongWordCounterAndFinder Class and stores the result to the longWordsCountResult integer.

                string[] longWordsFinderResult = LongWordCounterAndFinder.LongWordFinder(textToAnalyseArray);           // Passes the text to analyse array to the LongWordFinder method of the 
                                                                                                                        // ...LongWordCounterAndFinder Class and stores the result to the longWordsFinderResult array.
                #endregion

                #region Text Analysis Results Display Method Call
                TextAnalysisResultsDisplay.AnalysisResults                                                  // Passes the the results of the previous methods to the AnalysisResults method of the.... 
                            (textToAnalyse,                                                                 // ....TextAnalysisResultsDisplay Class. This displays the text analysis results to the console... 
                            countCharactersResult,                                                          // ....window, this method returns void.
                            wordCounterResult,
                            sentenceCounterResult,
                            paragraphCounterResult,
                            upperCaseCounterResult,
                            lowerCaseCounterResult,
                            longWordsCountResult);

                TextAnalysisResultsDisplay.SentimentAnalysisResults                                         // Passes the the results of the previous methods to the AnalysisResults method of the.... 
                            (negativeWordsArray,                                                            // ....TextAnalysisResultsDisplay Class. This displays the sentiment analysis results to the console...
                            positiveWordsArray,                                                             // ....window, this method returns void.
                            textToAnalyseArray,
                            positiveWordCounterResult,
                            negativeWordCounterResult,
                            negativeWordFrequency,
                            positiveWordFrequency,
                            sentimentResult);

                File.AppendAllLines(longWordsFile, longWordsFinderResult);                                  // Writes all of the words with 7 or more characters to the LongWords.txt file.
                #endregion

                #region User Options Selection For Continue/Exit Program
                continueOptionSelection = true;                                                             // Sets the continueOptionSelection boolean to true.


                Console.WriteLine                                                                           // Writes the text to the console window.
                    ("Would you like to start again and analyse more text? Or exit the program?" +
                    spacer + "\nThere are two options available, the options are:" +
                    "\nOption 1 - Start text analysis again." +
                    "\nOption 2 - Exit the program." +
                    spacer + "\nWould you like to use Option 1 or Option 2 - enter 1 or 2 and press enter.\n");

                while (continueOptionSelection == true)                                                     // While continueOptionSelection is true....
                {
                    Console.Write("Option: ");                                                              // Writes text to the console window.
                    string continueOrExit = Console.ReadLine();                                             // Sets the continueOrExit string to read the input from the console window.

                    if (continueOrExit == "1")                                                              // If continueOrExit is 1.... 
                    {
                        repeatProgram = true;                                                               // Repeat the program is true.
                        optionSelected = false;                                                             // Option selected is false.
                        continueOptionSelection = false;                                                    // Continue option selection is false.

                        textToAnalyse = "";                                                                 // Clear the textToAnalyse string.
                        userTextInput = "";                                                                 // Clear the userTextInput string.

                        Console.WriteLine                                                                   // Writes text to the console window.
                            (spacer + "\nOption 1 has been selected.\nYou have selected to start again, press enter to continue......" + spacerNoEndNewLine);  
                            
                        Console.ReadLine();                                                                 // Wait for user to press enter.
                    }
                    else if (continueOrExit == "2")                                                         // If continueOrExit is 2.... 
                    {
                        repeatProgram = false;                                                              // Repeat the program is false.
                        continueOptionSelection = false;                                                    // Continue option selection is false.

                        Console.WriteLine                                                                   // Writes text to the console window.
                            (spacer + "\nOption 2 has been selected.\nYou have selected exit the program, press enter to exit....." + spacerNoEndNewLine);

                        Console.ReadLine();                                                                 // Wait for user to press enter.
                    }
                    else                                                                                    // Else...
                    {
                        Console.WriteLine                                                                    // Writes text to the console window.
                            (spacer + "\nYou have not entered a valid response. Please try again." + spacer);
                    } 
                    #endregion
                }
            }
        }
    }
}
