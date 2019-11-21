using System;

namespace dev_3
{
    /// <summary>
    /// Program's entry point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try//Try your string here
            {
                var yourString = "";
                Translitor c = new Translitor(yourString);
                c.Translit();
                Console.WriteLine(c.ProcessedSentence);
            }
            catch (InvalidFormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Translitor a = new Translitor("Съешь ещё этих мягких французских булок, да выпей чаю");
            a.Translit();
            Translitor b = new Translitor(a.ProcessedSentence);
            b.Translit();
            Console.WriteLine(a.ProcessedSentence);
            Console.WriteLine(b.ProcessedSentence);
        }
    }
}