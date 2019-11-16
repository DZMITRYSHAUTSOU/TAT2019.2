using System;
using System.Linq;

namespace dev_2
{
    /// <summary>
    /// Class for analyzing string objects
    /// </summary>
    class StringAnalyzer
    {
        public string Sequence { get; } = String.Empty;
        private string LongestUniqueSymbolSubstring { get; set; } = String.Empty;
        private string LongestRepetitiveDigitSubstring { get; set; } = String.Empty;
        private string LongestRepetitiveLetterSubstring { get; set; } = String.Empty;
        /// <summary>
        /// Sets readonly propertie used for analyzing
        /// </summary>
        /// <param name="sequence">String for analyzing</param>
        public StringAnalyzer(string sequence)
        {
            Sequence = sequence;
        }
        /// <summary>
        /// This method calls every other method of the class
        /// </summary>
        public void Analyze()
        {
            LongestUniqueSymbolSubstring = GetUniqueSymbolSequence();
            LongestRepetitiveDigitSubstring = GetRepetitiveDigitSequence();
            LongestRepetitiveLetterSubstring = GetRepetitiveLetterSequence();
            DisplayInfo();
        }
        /// <summary>
        /// Finds unique symbol sequence
        /// </summary>
        /// <returns>string thar contains longest unique symbol sequence</returns>
        private string GetUniqueSymbolSequence()
        {
            for (int i = Sequence.Length; i > 0; i--)
            {
                for (int j = 0; j <= -(i - Sequence.Length); j++)
                {
                    if (IsSequenceUniqueOnly(Sequence.Substring(j, i)))
                        return Sequence.Substring(j, i);
                }
            }
            return String.Empty;
        }
        /// <summary>
        /// Finds repetitive digit sequence
        /// </summary>
        /// <returns>string that contains longest repetitive digit sequence</returns>
        public string GetRepetitiveDigitSequence()
        {
            string buffer = string.Join("", Sequence.Where(g => Enumerable.Range(48, 10).Contains(g)));
            for (int i = buffer.Length; i > 0; i--)
            {
                for (int j = 0; j <= -(i - buffer.Length); j++)
                {
                    if (IsSequenceRepetitiveOnly(buffer.Substring(j, i)))
                        return buffer.Substring(j, i);
                }
            }
            return String.Empty;
        }
        /// <summary>
        /// Finds repetitive digit sequence
        /// </summary>
        /// <returns>string that contains longest repetitive latin letter sequence</returns>
        public string GetRepetitiveLetterSequence()
        {
            string buffer = string.Join("", Sequence.Where(g => Enumerable.Range(65, 26).Contains(g) || Enumerable.Range(97, 26).Contains(g)));
            for (int i = buffer.Length; i > 0; i--)
            {
                for (int j = 0; j <= -(i - buffer.Length); j++)
                {
                    if (IsSequenceRepetitiveOnly(buffer.Substring(j, i)))
                        return buffer.Substring(j, i);
                }
            }
            return String.Empty;
        }
        /// <summary>
        /// Is sequence contains only different symbols
        /// </summary>
        /// <param name="sequence">string to analyze</param>
        /// <returns>Returns true if string contains only different symbols else false</returns>
        public bool IsSequenceUniqueOnly(string sequence)
        {
            return !sequence.GroupBy(g => g).Any(g => g.Count() > 1);
        }
        /// <summary>
        /// Is sequence consists of one repetitive symbol
        /// </summary>
        /// <param name="sequence">string to analyze</param>
        /// <returns>Returns true if string contains only one repetitive symbol </returns>
        public bool IsSequenceRepetitiveOnly(string sequence)
        {
            return !(sequence.GroupBy(g => g).Count() > 1);
        }
        /// <summary>
        /// Displays all the info about Sequence field, calls automatically after Analyzing
        /// </summary>
        private void DisplayInfo()
        {
            Console.WriteLine("Longest Unique Symbol Substring : " + LongestUniqueSymbolSubstring + " Length : " + LongestUniqueSymbolSubstring.Length + "\n" +
                "Longest Repetitive Digit Substring : " + LongestRepetitiveDigitSubstring + " Length : " + LongestRepetitiveDigitSubstring.Length + "\n" +
                "Longest Repetitive Letter Substring : " + LongestRepetitiveLetterSubstring + " Length : " + LongestRepetitiveLetterSubstring.Length);
        }
    }
}