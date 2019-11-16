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

        public StringAnalyzer(string sequence)
        {
            Sequence = sequence;
        }

        public void Analyze()
        {
            LongestUniqueSymbolSubstring = GetUniqueSymbolSequence();
            LongestRepetitiveDigitSubstring = GetRepetitiveDigitSequence();
            LongestRepetitiveLetterSubstring = GetRepetitiveLetterSequence();
            DisplayInfo();
        }

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

        public bool IsSequenceUniqueOnly(string sequence)
        {
            return !sequence.GroupBy(g => g).Any(g => g.Count() > 1);
        }

        public bool IsSequenceRepetitiveOnly(string sequence)
        {
            return !(sequence.GroupBy(g => g).Count() > 1);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Longest Unique Symbol Substring : " + LongestUniqueSymbolSubstring + " Length : " + LongestUniqueSymbolSubstring.Length + "\n" +
                "Longest Repetitive Digit Substring : " + LongestRepetitiveDigitSubstring + " Length : " + LongestRepetitiveDigitSubstring.Length + "\n" +
                "Longest Repetitive Letter Substring : " + LongestRepetitiveLetterSubstring + " Length : " + LongestRepetitiveLetterSubstring.Length);
        }
    }
}