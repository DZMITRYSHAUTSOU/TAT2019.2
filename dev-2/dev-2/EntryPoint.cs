using System;

namespace dev_2
{
    /// <summary>
    /// Program's entry point 
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            StringAnalyzer a = new StringAnalyzer(Console.ReadLine());
            a.Analyze();
        }
    }
}
