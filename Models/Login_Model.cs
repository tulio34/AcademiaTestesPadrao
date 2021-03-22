using AcademiaDeTestes.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AcademiaDeTestes.Models
{
    public class Login_Model
    {
        private IWebDriver driver;
        private Login_Page login;


        public Login_Model(IWebDriver superDriver)
        {
            driver = superDriver;
            login = new Login_Page(driver);
        }


        public void realizarLogin(String sEmailLogin, String sPass)
        {
            login.inputEmailLogin().SendKeys(sEmailLogin);
            login.inputPassLogin().SendKeys(sPass);
            login.btnLogin().Click();

        }

        public void novoCadastro(String sEmail)
        {
            login.inputEmailCadastro().SendKeys(sEmail);
            login.btnCriarConta().Click();
        }

        public void realizarLogout()
        {
            login.btnLogout().Click();
        }




    }
}