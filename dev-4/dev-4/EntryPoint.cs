using System;

namespace dev_4
{
    /// <summary>
    /// Program's entry point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            MailRuProcessorChrome processor = new MailRuProcessorChrome("epam_tat2019","CorrectPassword");//Throw your Login data here
            try
            {
                processor.ExecuteActionSequence();
                processor.DisplayResults();
            }
            catch(InvalidLoginOrPasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}