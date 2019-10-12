using Meu_Projeto_de_Testes_automação.page_objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Windows.Input;
using System;
using System.Threading;

namespace Meu_Projeto_de_Testes_automação.page_controler
{
    public class Google_controler : google_page
    {

        public static void SetInputGoogle(string text)
        {
            driver.FindElement(inputGoogle()).SendKeys(text + Keys.Enter);
        }

        public static void Clickopçãospeedtest()
        {
            driver.FindElement(Opçãotestcopel()).Click();
        }

        public static void ClickOpçaoCorreios()
        {
            driver.FindElement(OpçaoCorreios()).Click();
        }
        public static void ClickOpçãoPrecisaDeAjuda()
        {
            driver.FindElement(OpçaoPrecisadeAjuda()).Click();
        }

        public static void sobreLogistica()
        {
           
        }

        public static void ClickOpçãoguiatec()
        {
            driver.FindElement(Opçaoguiatec()).Click();
        }


        public static void ClickbuttonSkipSignIn()
        {
            driver.FindElement(buttonSkipSignIn()).Click();
        }
        public static void setinputfirstname(string text)
        {
            driver.FindElement(opçaofirstname()).SendKeys(text);
            Thread.Sleep(2000);
        }
        public static void setinputlastname(string text)
        {
            driver.FindElement(opçaolastname()).SendKeys(text);
            Thread.Sleep(2000);
        }

        public static void moveoptionsinteractions()
        {
            Actions a = new Actions(driver);
            a.MoveToElement(driver.FindElement(opçaoiteractions())).Build().Perform();
        }
        public static void setinputAdress(string text)
        {
            driver.FindElement(opçaoAdress()).SendKeys(text);
            Thread.Sleep(2000);
        }
        public static void setinputemailadress(string text)
        {
            driver.FindElement(opçaoEmailAdress()).SendKeys(text);
            Thread.Sleep(2000);
        }
        public static void setinputphone(string text)
        {
            driver.FindElement(opçaoPhone()).SendKeys(text);
            Thread.Sleep(2000);
        }
        public static void ClickMale()
        {
            driver.FindElement(opçaomale()).Click();
            Thread.Sleep(2000);
        }
        public static void Clickcheckbox1()
        {
            driver.FindElement(checkboxcricket1()).Click();
            Thread.Sleep(2000);
        }
        public static void Clickcheckbox3()
        {
            driver.FindElement(checkboxcricket3()).Click();
            Thread.Sleep(2000);
        }
        public static void Clicklanguages()
        {
            driver.FindElement(opçaolanguages()).Click();
            Thread.Sleep(2000);
        }
        public static void ClickEnglish()
        {
            driver.FindElement(languages_English()).Click();
            Thread.Sleep(2000);
        }






    }
}
