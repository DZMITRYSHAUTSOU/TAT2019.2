using OpenQA.Selenium.Chrome;
using dev_5.Managers;

namespace dev_5
{
    /// <summary>
    /// Program's entry point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            MailRuManager mailRuManager = new MailRuManager(new ChromeDriver(), "epam_tat2019", "CorrectPassword");
            mailRuManager.SignIn();
            mailRuManager.SendTestMessage("hideoisgenius.v.2@gmail.com");
            GMailManager gMailManager = new GMailManager(new ChromeDriver(), "hideoisgenius.v.2", "DeathStranding");
            gMailManager.SignIn();
            gMailManager.ReplyWithDefaultEmailTo("epam_tat2019@mail.ru");
            mailRuManager.SearchEmailFrom("hideoisgenius.v.2@gmail.com");
        }
    }
}
