using System;
using OpenQA.Selenium;

namespace AcademiaDeTestes.Pages
{
    public class Login_Page
    {
        private IWebDriver driver;
        public Login_Page(IWebDriver superDriver)
        {
            driver = superDriver;
        }

        public IWebElement inputEmailCadastro()
        {
            return driver.FindElement(By.Id("email_create"));
        }

        public IWebElement btnCriarConta()
        {
            return driver.FindElement(By.Id("SubmitCreate"));
        }

        public IWebElement inputEmailLogin()
        {
            return driver.FindElement(By.Id("email"));
        }

        public IWebElement inputPassLogin()
        {
            return driver.FindElement(By.Id("passwd"));
        }

        public IWebElement btnLogin()
        {
            return driver.FindElement(By.XPath("//*[@id='SubmitLogin']"));
        }


        public IWebElement btnLogout()
        {
            return driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[2]/a"));
        }
    }
}