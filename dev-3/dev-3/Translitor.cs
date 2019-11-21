using System;
using System.Collections.Generic;
using System.Linq;

namespace dev_3
{
    /// <summary>
    /// Class for transliting sentences.
    /// Fields may look strange, because methods are working with indices of arrays.
    /// </summary>
    public class Translitor
    {
        public string Sentence { get; }
        public string ProcessedSentence { get; private set; } = string.Empty;
        private bool IsRussian = false;
        private string[] _translitRule = new string[] {"a","b", "v", "g", "d", "e", "zh", "z", "i", "y", "k", "l",
        "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "sch", "", "y", "", "e", "yu", "ya","","yo"};
        private string[] _twoSymbolsTranslit = new string[] {"","", "", "", "", "", "zh", "", "", "", "", "",
        "", "", "", "", "", "", "", "", "", "kh", "ts", "ch", "sh", "sch", "", "", "", "", "yu", "ya","","yo"};
        public const int RUSSIANLOWERCASEA = 1072;
        public const int LATINLOWERCASEA = 97;
        public IEnumerable<int> LatinLowerCaseRange = Enumerable.Range(97, 27);
        public IEnumerable<int> RussianLowerCaseRange = Enumerable.Range(1072, 34);
        /// <summary>
        /// Constructor that takes string, checks its validity and sets mode of transliting
        /// </summary>
        /// <param name="sentence">this string will be processed</param>
        public Translitor(string sentence)
        {
            CheckValidity(sentence.ToLower());
            Sentence = sentence.ToLower();
            SetMode();
        }
        /// <summary>
        /// There are 2 modes : from russian to translit and from translit to russian
        /// </summary>
        private void SetMode()
        {
            IsRussian = Sentence.Any(c => RussianLowerCaseRange.Contains(c));
        }
        /// <summary>
        /// Checks validity of sentence. Throws exception if it contains both russian and latin character
        /// </summary>
        /// <param name="sentence">string sentence to process</param>
        private void CheckValidity(string sentence)
        {
            if (sentence.Any(c => LatinLowerCaseRange.Contains(c)) && sentence.Any(c => RussianLowerCaseRange.Contains(c)))
            {
                throw new InvalidFormatException();
            }
        }
        /// <summary>
        /// This method translits sentence according to current mode.
        /// From russian to translit is working fine.
        /// </summary>
        public void Translit()
        {
            ProcessedSentence = IsRussian ? FromRussian() : ToRussian();
        }
        /// <summary>
        /// Translits sentence in russian.
        /// </summary>
        /// <returns>Translited sentence</returns>
        public string FromRussian()
        {
            return string.Join("", Sentence.Select(c => RussianLowerCaseRange.Contains(c) ? _translitRule[c - RUSSIANLOWERCASEA].ToString() : c.ToString()));
        }
        /// <summary>
        /// This method reverser translit from latin to russian. 
        /// </summary>
        /// <returns>Russian string</returns>
        public string ToRussian()
        {
            ProcessedSentence = Sentence;
            for (int i = 0; i < _twoSymbolsTranslit.Length; i++)
            {
                if (ProcessedSentence.Contains(_twoSymbolsTranslit[i]) && !_twoSymbolsTranslit[i].Equals(""))
                {
                    ProcessedSentence = ProcessedSentence.Replace(_twoSymbolsTranslit[i], ((char)(RUSSIANLOWERCASEA + i)).ToString());
                }
            }
            for (int i = 0; i < ProcessedSentence.Length; i++)
            {
                if (_translitRule.Contains(ProcessedSentence[i].ToString()))
                {
                    ProcessedSentence = ProcessedSentence.Replace(ProcessedSentence[i], (char)(RUSSIANLOWERCASEA + Array.IndexOf(_translitRule, ProcessedSentence[i].ToString())));
                }
            }
            return ProcessedSentence;
        }
    }
}