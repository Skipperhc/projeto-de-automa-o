using Meu_Projeto_de_Testes_automação.page_objects.Desktop;

namespace Meu_Projeto_de_Testes_automação.page_controler.Desktop
{
    public class calccontroler :calcpage
    {
        
        public static void clickbutton1()
        {
            Driver.FindElement(Numero1()).Click();
        }
        public static void clickbutton2()
        {
            Driver.FindElement(Numero2()).Click();
        }
        public static void clickbutton3()
        {
            Driver.FindElement(Numero3()).Click();
        }
        public static void clickbutton4()
        {
            Driver.FindElement(Numero4()).Click();
        }
        public static void clickbutton5()
        {
            Driver.FindElement(Numero5()).Click();
        }
        public static void clickbutton6()
        {
            Driver.FindElement(Numero6()).Click();
        }
        public static void clickbutton7()
        {
            Driver.FindElement(Numero7()).Click();
        }
        public static void clickbutton8()
        {
            Driver.FindElement(Numero8()).Click();
        }
        public static void clickbutton9()
        {
            Driver.FindElement(Numero9()).Click();
        }
        public static void clickbutton0()
        {
            Driver.FindElement(Numero0()).Click();
        }
        public static void clickbuttonsoma()
        {
            Driver.FindElement(ButtonSoma()).Click();
        }
        public static void clickbuttonigual()
        {
            Driver.FindElement(ButtonIgual()).Click();
        }
        public static void clickbuttondivide()
        {
            Driver.FindElement(ButtonDivide()).Click();
        }
        public static void clickbuttonmultiplica()
        {
            Driver.FindElement(ButtonMultiplica()).Click();
        }
        public static void clickbuttonsubtrair()
        {
            Driver.FindElement(ButtonSubtrair()).Click();
        }
        public static void clickbuttonlimpar()
        {
            Driver.FindElement(Buttonlimpar()).Click();
        }


    }
}
