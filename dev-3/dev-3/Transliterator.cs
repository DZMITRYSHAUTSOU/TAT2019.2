using System;
using System.Collections.Generic;
using System.Linq;

namespace dev_3
{
    /// <summary>
    /// Class for transliting sentences.
    /// Fields may look strange, because methods are working with indices of arrays.
    /// All transliterations are made according to transliteration table at https://www.westernunion.ru/ru/ru/transliteration-table.html
    /// </summary>
    public class Transliterator
    {
        public string Sentence { get; }
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
        /// Constructor that takes string, checks its validity and sets mode of transliteration
        /// </summary>
        /// <param name="sentence">this string will be processed</param>
        public Transliterator(string sentence)
        {
            CheckValidity(sentence);
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
            if (sentence is null || (sentence.Any(c => LatinLowerCaseRange.Contains(c)) && sentence.Any(c => RussianLowerCaseRange.Contains(c))))
            {
                throw new InvalidFormatException();
            }
        }
        /// <summary>
        /// This method calls transliteration methods for sentence according to current mode.
        /// From russian to translit is working fine.
        /// </summary>
        public string Translit()
        {
            return IsRussian ? FromRussian() : ToRussian();
        }
        /// <summary>
        /// Transliterate sentence in russian.
        /// </summary>
        /// <returns>Translited sentence</returns>
        private string FromRussian()
        {
            return string.Join("", Sentence.Select(c => RussianLowerCaseRange.Contains(c) ? _translitRule[c - RUSSIANLOWERCASEA].ToString() : c.ToString()));
        }
        /// <summary>
        /// This method reverser transliteration from latin to russian. 
        /// </summary>
        /// <returns>Russian string</returns>
        private string ToRussian()
        {
            string ProcessedSentence = Sentence;
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