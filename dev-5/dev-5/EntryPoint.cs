using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using dev_5.Managers;
using dev_5.GMail;

namespace dev_5
{
    /// <summary>
    /// Program's entry point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            MailRuManager managerRu = new MailRuManager(new ChromeDriver(), "epam_tat2019", "CorrectPassword");
            managerRu.SignIn();
            managerRu.SendTestMessage("hideoisgenius.v.2@gmail.com");
            GMailManager managerG = new GMailManager(new ChromeDriver(), "hideoisgenius.v.2", "DeathStranding");
            managerG.SignIn();
            managerG.ReplyWithDefaultEmailTo("epam_tat2019@mail.ru");
            managerRu.SearchEmailFrom("hideoisgenius.v.2@gmail.com");
        }
    }
}
