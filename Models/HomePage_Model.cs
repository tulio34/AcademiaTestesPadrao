using AcademiaDeTestes.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AcademiaDeTestes.Models
{
    public class HomePage_Model
    {
        private IWebDriver driver;
        private HomePage_Page home;
     

        public HomePage_Model(IWebDriver superDriver)
        {
            driver = superDriver;
            home = new HomePage_Page(driver);
        }





        public void pesquisarProduto(String sProduto)
        {
            Assert.IsTrue(home.inputPesquisar().Displayed);
            home.inputPesquisar().SendKeys(sProduto);
            home.btnPesquisar().Click();
        }

        public void selecionarProduto()
        {
            home.btnAbrirModoLista().Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            home.linkSelecionarProduto().Click();
        }


        public void AbrirMenuDepartamento()
        {
            Assert.IsTrue(home.abrirMenuDepartamento().Displayed);
            home.abrirMenuDepartamento().Click();
            home.btnAbrirModoLista().Click();
            home.linkSelecionarProduto().Click();
        }


        public void colocarNoCarrinho()
        {
            home.colocarItemNoCarrinho().Click();
        }


        public void acessarPaginaLogin()
        {
            home.clicarSignIn().Click();
        }
    }
}
