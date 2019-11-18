using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_3
{
    class Translitor
    {
        public string Sentence { get; }
        public string ProcessedSentence { get; private set; } = string.Empty;
        private bool IsRussian = false;
        private string[] _translitRule = new string[] {"a","b", "v", "g", "d", "e", "zh", "z", "i", "y", "k", "l",
        "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "sch", "", "y", "", "e", "yu", "ya",};
        private string[] _twoSymbolsTranslit = new string[] {"","", "", "", "", "", "zh", "", "", "", "", "",
        "", "", "", "", "", "", "", "", "", "kh", "ts", "ch", "sh", "sch", "", "", "", "", "yu", "ya",};
        public IEnumerable<int> LATINLOWERCASERANGE = Enumerable.Range(97, 26);
        public IEnumerable<int> RUSSIANLOWERCASERANGE = Enumerable.Range(1072, 32);

        public Translitor(string sentence)
        {
            CheckValidity(sentence.ToLower());
            Sentence = sentence.ToLower();
            SetMode();
        }

        private void SetMode()
        {
            IsRussian = Sentence.Any(c => RUSSIANLOWERCASERANGE.Contains(c));
        }

        private void CheckValidity(string sentence)
        {
            if (sentence.Any(c => LATINLOWERCASERANGE.Contains(c)) && sentence.Any(c => RUSSIANLOWERCASERANGE.Contains(c)))
            {
                throw new InvalidFormatException();
            }
        }

        public void Translit()
        {
            ProcessedSentence = IsRussian ? string.Join("", Sentence.Select(c =>RUSSIANLOWERCASERANGE.Contains(c) ? _translitRule[c - 1072].ToString() : c.ToString())) :
                test();
        }
        public string test()
        {
            ProcessedSentence = Sentence;
            for(int i=0;i<_twoSymbolsTranslit.Length;i++)
            {
                if(ProcessedSentence.Contains(_twoSymbolsTranslit[i]) && !_twoSymbolsTranslit[i].Equals(""))
                {
                    ProcessedSentence=ProcessedSentence.Replace(_twoSymbolsTranslit[i], ((char)(1072 + i)).ToString());
                    //Console.WriteLine("hit");
                }
            }
            for (int i = 0; i < ProcessedSentence.Length; i++)
            {
                if (_translitRule.Contains(ProcessedSentence[i].ToString()))
                {
                    ProcessedSentence = ProcessedSentence.Replace(ProcessedSentence[i], (char)(1072 + Array.IndexOf(_translitRule, ProcessedSentence[i].ToString())));
                }
            }
            return ProcessedSentence;
        }
    }
}
