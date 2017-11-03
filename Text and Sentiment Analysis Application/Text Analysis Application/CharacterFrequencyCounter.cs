using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1127M_PartB
{
    public class CharacterFrequencyCounter
    {
        public static void CountCharacterFrequency(string textToAnalyse)                // Character frequency counting method. Method takes 1 string agrument. Counts frequencies of individual letters & prints....
        {                                                                               // ....the letters and the number of occurances in the string.

            int[] characterFreqencies = new int[char.MaxValue];                         // The integer array variable characterFreqencies is declared, the variable is assigned as a new integer array with a....
                                                                                        // ....size that is the largest possible value of a Char datatype.

            foreach (char character in textToAnalyse)                                   // The foreach loop will iterate over each character in the string.
            {
                characterFreqencies[character]++;                                       // The characterFreqencies int array index is incremented by 1 for every occurance of a character.
            }

            for (int i = 0; i < char.MaxValue; i++)                                     // The for loop is started and will iterate through the max value constant of the char datatype.
            {
                if (characterFreqencies[i] > 0 && char.IsLetterOrDigit((char)i))        // If the characterFreqencies index is greater than 0 AND the character is a letter or digit ....
                {
                    Console.WriteLine("There is/are:\t{0}\toccurance(s) of the character:\t '{1}'", characterFreqencies[i], (char)i);   // Display the number of occurances of each character.... 
                }                                                                                                                       // ....and also the character itself.
            }
        }
    }
}
