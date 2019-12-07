using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    /// <summary>
    /// Counts number of consequent repeated letters
    /// </summary>
    public class SequenceCounter
    {
        private string str = string.Empty;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="str"> Contains string to be processed</param>
        public SequenceCounter(string str)
        {
            this.str = str;
        }

        /// <summary>
        /// Counts max number of repeated letters
        /// </summary>
        /// <returns>max number of repeated letters</returns>
        public int Count()
        {
            List<int> numArray = new List<int>();
            int counter = 1;
            char currentChar = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == currentChar)
                {
                    counter++;
                }
                else
                {
                    numArray.Add(counter);
                    counter = 1;
                    currentChar = str[i];
                }
            }
            numArray.Add(counter);
            return numArray.OrderBy(num => num).Last();
        }
    }

}
