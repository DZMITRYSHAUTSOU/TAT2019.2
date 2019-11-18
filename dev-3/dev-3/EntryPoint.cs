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
            Translitor a = new Translitor("dabdabya");
            Translitor b = new Translitor("дабдабя");
            a.Translit();
            b.Translit();
            Console.WriteLine(a.ProcessedSentence);
            Console.WriteLine(b.ProcessedSentence);
        }
    }
}
