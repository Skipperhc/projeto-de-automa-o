using System;
using System.Threading;
using Meu_Projeto_de_Testes_automação.page_controler.Desktop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Meu_Projeto_de_Testes_automação.teste.Desktop
{
    [TestClass]
    public class calcteste : TestBaseDesktop
    {
        [TestMethod]
        public void TestMethod1()
        {
            calccontroler.clickbutton1();
            calccontroler.clickbutton2();
            calccontroler.clickbutton3();
            calccontroler.clickbuttonsoma();
            calccontroler.clickbutton4();
            calccontroler.clickbutton5();
            calccontroler.clickbutton6();
            calccontroler.clickbuttondivide();
            calccontroler.clickbutton7();
            calccontroler.clickbutton8();
            calccontroler.clickbutton9();
            calccontroler.clickbuttonsubtrair();
            calccontroler.clickbutton2();
            Thread.Sleep(2000);
            calccontroler.clickbuttonigual();
            calccontroler.clickbuttonlimpar();



            Thread.Sleep(5000);

        }
    }
}
