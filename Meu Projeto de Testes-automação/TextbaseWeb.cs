using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace Meu_Projeto_de_Testes_automação
{
    public class TextbaseWeb
    {
        public static ChromeDriver driver;
           
       [TestInitialize]
       public void inicio()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Index.html"); //URL que ira iniciar
            driver.Manage().Window.Maximize();   //janela Maximize 

        }

        [TestCleanup]
        public void fim() //desliga o chrome
        {
            driver.Quit();
        }
    }
}
