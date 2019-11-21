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
                Transliterator c = new Transliterator(yourString);
                Console.WriteLine(c.Translit());
            }
            catch (InvalidFormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Transliterator a = new Transliterator("Съешь ещё этих мягких французских булок, да выпей чаю");
            Transliterator b = new Transliterator(a.Translit());
            Console.WriteLine(a.Translit());
            Console.WriteLine(b.Translit());
        }
    }
}