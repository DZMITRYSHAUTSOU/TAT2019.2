using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    /// <summary>
    /// Counts number of consequent repeated letters
    /// </summary>
    public class SequenceCounter
    {
        public string StringForProcessing { get; set; }
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="str"> Contains string to be processed</param>
        public SequenceCounter(string stringForProcessing)
        {
            StringForProcessing = stringForProcessing;
        }
        /// <summary>
        /// Counts max number of repeated letters
        /// </summary>
        /// <returns>max number of repeated letters</returns>
        public int GetMaxCountOfRepeatedLetters()
        {
            if (StringForProcessing != null && StringForProcessing != string.Empty)
            {
                List<int> lettersCountList = new List<int>();
                int counter = 1;
                char currentChar = StringForProcessing[0];
                for (int i = 1; i < StringForProcessing.Length; i++)
                {
                    if (StringForProcessing[i] == currentChar)
                    {
                        counter++;
                    }
                    else
                    {
                        lettersCountList.Add(counter);
                        counter = 1;
                        currentChar = StringForProcessing[i];
                    }
                }
                lettersCountList.Add(counter);
                return lettersCountList.OrderBy(num => num).Last();
            }
            else
            {
                return 0;
            }
        }
    }

}
