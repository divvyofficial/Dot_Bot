using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OpenQA.Selenium.Support.Extensions;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Bots
{
    public class Robo
    {
        IWebDriver driver;
        enum TipoElemento { id, nome, css };
        Thread t;
        private ResultDelegate callback;

        public String Ret
        { get; set; }

        public delegate void ResultDelegate(String valor);

        public Robo(ResultDelegate _callback)
        {
            callback = _callback;
        }

        public void Inicar()
        {
            AbrirNavegador();

            PreparaPesquisa();

            GetDados();

        }

        private Boolean AbrirNavegador()
        {
            try 
            {
                driver = new ChromeDriver("C:\\");
                ChromeOptions options = new ChromeOptions();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }

        public Boolean GetDados()
        {
            String json = @"{";

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            IList<IWebElement> inputs = driver.FindElement(By.Id("conteudo")).FindElements(By.TagName("input"));

            Thread.Sleep(2500);

            int controle = 0; 

            foreach (IWebElement input in inputs)
            {
                String valor = input.GetAttribute("value");
                String name = input.GetAttribute("name");
                if (controle == 0)
                {
                    json = json + @" """ + name.Trim() + @" "" : """ + valor.Trim() + @"""";
                }
                else
                {
                    json = json + @", """ + name.Trim() + @" "" : """ + valor.Trim() + @"""";
                }
                controle++;
            }

            json = json + " }";
            
            MessageBox.Show(json, "Resultado JSON",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            return true;
        }

        private Boolean PreparaPesquisa()
        {
            try
            {
                driver.Navigate().GoToUrl("http://smap14.mda.gov.br/extratodap/PesquisarDAP");

                IWebElement a = driver.FindElement(By.XPath("//*[contains(@onclick, 'Fisica')]"));
                a.Click();
                Thread.Sleep(2500);

                if (!AguardaElemento(TipoElemento.css, "[href*='#Municipio']", 20))
                {
                    /*
                     * 
                     * Caso necessário pode fazer todo o código em um loop que da um return false e na chamada caso venha falso reinicia o bot
                     * 
                    */
                }


                IWebElement b = driver.FindElement(By.CssSelector("[href*='#Municipio']"));
                b.Click();

                Thread.Sleep(1500);

                if (!AguardaElemento(TipoElemento.id, "ddlUF", 20))
                {
                    //return false;
                }

                IWebElement c = driver.FindElement(By.Id("ddlUF"));
                SelectElement seleC = new SelectElement(c);
                seleC.SelectByValue("42");

                Thread.Sleep(1500);

                if (!AguardaElemento(TipoElemento.id, "ddlMunicipio", 20))
                {
                    //return false;
                }

                IWebElement d = driver.FindElement(By.Id("ddlMunicipio"));
                SelectElement seleD = new SelectElement(d);
                seleD.SelectByValue("4201208");

                Thread.Sleep(1500);

                GetImagCaptcha();

                Thread.Sleep(1500);

                if (!AguardaElemento(TipoElemento.id, "btnPesquisarMunicipio", 20))
                {
                    //return false;
                }

                IList<IWebElement> botoes = driver.FindElements(By.Id("btnPesquisarMunicipio"));

                IWebElement e = driver.FindElement(By.Id("btnPesquisarMunicipio"));
                string script = botoes[2].GetAttribute("onclick");
                driver.ExecuteJavaScript<object>(script);
                //e.Click();

                Thread.Sleep(3500);

                if (!AguardaElemento(TipoElemento.id, "gridPessoaFisica", 20, true))
                {
                    //return false;
                }

                IList<IWebElement> f = driver.FindElement(By.Id("gridPessoaFisica")).FindElements(By.TagName("a"));

                Thread.Sleep(2500);

                foreach (IWebElement link in f)
                {
                    string onclick = link.GetAttribute("onclick");
                    driver.ExecuteJavaScript<object>(onclick);
                    break;
                }

                Thread.Sleep(2500);

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        private Boolean AguardaElemento(TipoElemento tipo, String nomeElemento, Int32 tempoEspera, Boolean checkStyle = false)
        {
            Boolean retorno = true;
            try
            {
                if (tipo == TipoElemento.id)
                {
                    WebDriverWait aguarda = new WebDriverWait(driver, TimeSpan.FromSeconds(tempoEspera));
                    aguarda.Until(d => d.FindElement(By.Id(nomeElemento)));

                    retorno = VerificaStyle(checkStyle, nomeElemento);

                    return retorno;

                }
                else if (tipo == TipoElemento.nome)
                {
                    WebDriverWait aguarda = new WebDriverWait(driver, TimeSpan.FromSeconds(tempoEspera));
                    aguarda.Until(d => d.FindElement(By.Name(nomeElemento)));
                    return retorno;

                }
                else if (tipo == TipoElemento.css)
                {
                    WebDriverWait aguarda = new WebDriverWait(driver, TimeSpan.FromSeconds(tempoEspera));
                    aguarda.Until(d => d.FindElement(By.CssSelector(nomeElemento)));
                    return retorno;

                }

            }
            catch (Exception ex)
            {

                return false;
            }

            return false;

        }

        private Boolean VerificaStyle(Boolean checkStyle, String id)
        {
            int n = 0;

            if (checkStyle)
            {
                while (n < 5)
                {
                    IWebElement css2 = driver.FindElement(By.Id(id));
                    if (css2.Displayed)
                    {
                        return true;
                    }
                    Thread.Sleep(5000);
                }
            }
            return false;
        }

        public Boolean GetImagCaptcha()
        {
            try
            {
                WebDriverWait aguarda = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                aguarda.Until(d => d.FindElement(By.Id("m_imgCaptchaMunicipio")));

                String imagemSRC = driver.FindElement(By.Id("m_imgCaptchaMunicipio")).GetAttribute("src");

                imagemSRC = imagemSRC.Replace("data:image/png;base64,", "");

                Image img = Base64ToImage(imagemSRC);

                FormInCaptcha Dialog = new FormInCaptcha(img);

                Thread.Sleep(2500);

                Dialog.ShowDialog();

                String cpt = Dialog.captcha;

                if (cpt == null)
                {

                    Dialog.Dispose();
                    return false;

                }
                else
                {
                    Dialog.Dispose();
                    InCaptcha(cpt);
                    return true;
                }
            }
            catch (Exception e)
            {

                return false;
            }


        }

        public Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        private Boolean InCaptcha(String _captcha)
        {
            driver.FindElement(By.Id("m_tbCaptchaMunicipio")).SendKeys(_captcha);
            return true;
        }
        
    }
}
