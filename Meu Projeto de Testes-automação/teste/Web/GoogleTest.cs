using Meu_Projeto_de_Testes_automação.page_controler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Meu_Projeto_de_Testes_automação
{
    [TestClass]
    public class GoogleTest : TextbaseWeb
    {
        [TestMethod]
        public void Pesquisa_Google()
        {

            Google_controler.ClickbuttonSkipSignIn();

            Google_controler.setinputfirstname("texto exemplo");

            Google_controler.setinputlastname("teto exemplo last name");

            //Google_controler.moveoptionsinteractions();

            Google_controler.setinputAdress("e ai, por acaso, sera que? tem um limite para o que eu posso escrever?? vaaaaaaaaaaamooooos, canseiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

            Google_controler.setinputemailadress("vitorhainosz2@hotmail.com");

            Google_controler.setinputphone("99999999");

            Google_controler.ClickMale();

            Google_controler.Clickcheckbox1();

            Google_controler.Clickcheckbox3();

            Google_controler.Clicklanguages();

            Google_controler.ClickEnglish();


            
            /*Google_controler.SetInputGoogle("Correios");

            Google_controler.ClickOpçaoCorreios();

            Google_controler.sobreLogistica();

            Google_controler.*/

            //Google_controler.ClickOpçãoguiatec();

        }
    }
}
