using OpenQA.Selenium;

namespace AcademiaDeTestes.Pages
{
    public class Cadastro_Page
    {
        private IWebDriver driver;
        public Cadastro_Page(IWebDriver superDriver)
        {
            driver = superDriver;
        }



        public IWebElement radioGender1()
        {
            return driver.FindElement(By.Id("id_gender1"));
        }


        public IWebElement radioGender2()
        {
            return driver.FindElement(By.Id("id_gender2"));
        }

        public IWebElement inputPreencherPrimeiroNome()
        {
            return driver.FindElement(By.Id("customer_firstname"));
        }

        public IWebElement inputPreencherSobrenome()
        {
            return driver.FindElement(By.Id("customer_lastname"));
        }

        public IWebElement inputPreencherSenha()
        {
            return driver.FindElement(By.Id("passwd"));
        }

        public IWebElement inputPreencherEndereco()
        {
            return driver.FindElement(By.Id("address1"));
        }

        public IWebElement inputCidade()
        {
            return driver.FindElement(By.Id("city"));
        }
        public IWebElement inputEstado()
        {
            return driver.FindElement(By.XPath("//*[@id='id_state']/option[7]"));
        }

        public IWebElement inputCodigoPostal()
        {
            return driver.FindElement(By.Id("postcode"));
        }
        public IWebElement inputPais()
        {
            return driver.FindElement(By.Id("id_country"));
        }
        public IWebElement inputTelefoneCelular()
        {
            return driver.FindElement(By.Id("phone_mobile"));
        }
        public IWebElement btnConfirmarCriacaoUsuario()
        {
            return driver.FindElement(By.Id("submitAccount"));
        }


        public IWebElement checarMyAccount()
        {
            return driver.FindElement(By.XPath("//*[@id='center_column']/h1"));
        }




    }
}
