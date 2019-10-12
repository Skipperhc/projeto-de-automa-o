using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Winium;

namespace Meu_Projeto_de_Testes_automação
{
    public class TestBaseDesktop
    {
        public static WiniumDriver Driver;

        public static DesktopOptions Option;

        public static string local = @"C:\Windows\System32\calc.exe";

        [TestInitialize]
        public void initializate()
        {
            Option = new DesktopOptions();
            Option.ApplicationPath = local;
            Driver = new WiniumDriver("Driver", Option);
        }
    }
}
