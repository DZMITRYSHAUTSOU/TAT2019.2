using System;

namespace dev_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            StringAnalyzer a = new StringAnalyzer(Console.ReadLine());
            a.Analyze();
        }
    }
}
