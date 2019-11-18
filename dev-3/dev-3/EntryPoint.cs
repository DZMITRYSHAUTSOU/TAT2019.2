using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Translitor a = new Translitor("dab dab ya");
            Translitor b = new Translitor("даб даб я");
            a.Translit();
            b.Translit();
            Console.WriteLine(a.ProcessedSentence);
            Console.WriteLine(b.ProcessedSentence);
            string test = "dab dab ya";
            //test = test.Replace("ya", "я");
        }
    }
}
