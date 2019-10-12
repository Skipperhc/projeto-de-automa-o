using OpenQA.Selenium;

namespace Meu_Projeto_de_Testes_automação.page_objects
{

    public class google_page : TextbaseWeb
    {
        public static By inputGoogle()
        {
            return By.Name("q");
        }

        public static By Opçãotestcopel()
        {
            return By.XPath("(//a[@href='http://speedtest.copel.net/'])[1]");
        }

        public static By OpçaoCorreios()
        {
            return By.XPath("(//a[@href='http://www.correios.com.br/'])[1]");
        }
        public static By OpçaoPrecisadeAjuda()
        {
            return By.XPath("");
        }
        public static By Opçaoguiatec()
        {
            return By.XPath("(//a[@href='http://www.correios.com.br/precisa-de-ajuda/como-enderecar-cartas-e-encomendas/guia-tecnico-de-enderecamento-de-encomendas/'])[1]");
        }
        public static By Opçaoencomendaselogistica()
        {
            return By.XPath("(//a[@href='http://www.correios.com.br/encomendas-logistica'])[1]");
        }
        public static By buttonSkipSignIn()
        {
            return By.Id("btn2");
        }
        public static By opçaofirstname()
        {
            return By.XPath("//input[@placeholder = 'First Name']");
        }
        public static By opçaolastname()
        {
            return By.XPath("//input[@placeholder = 'Last Name']");
        }
        public static By opçaoiteractions()
        {
            return By.XPath("(//a[@data-toggle='dropdown'])[3]");
        }
        public static By opçaoAdress()
        {
            return By.XPath("//*[@ng-model='Adress']");
        }
        public static By opçaoEmailAdress()
        {
            return By.XPath("//*[@ng-model='EmailAdress']");
        }
        public static By opçaoPhone()
        {
            return By.XPath("//*[@ng-model='Phone']");
        }
        public static By opçaomale()
        {
            return By.XPath("//*[@ng-model='radiovalue']");
        }
        public static By checkboxcricket1()
        {
            return By.XPath("//*[@id='checkbox1']");
        }
        public static By checkboxcricket3()
        {
            return By.XPath("//*[@id='checkbox3']");
        }
        public static By languages_English()
        {
            return By.XPath("//*[@id='basicBootstrapForm']/div[7]/div/multi-select/div[2]/ul/li[8]/a");
        }
        public static By opçaolanguages()
        {
            return By.Id("msdd");
        }
        





    }
}
