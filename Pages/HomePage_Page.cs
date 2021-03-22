using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaDeTestes.Pages
{
    public class HomePage_Page
    {
        private IWebDriver driver;
        public HomePage_Page(IWebDriver superDriver)
        {
            driver = superDriver;
        }



        public IWebElement inputPesquisar()
        {
            return driver.FindElement(By.Id("search_query_top"));
        }

        public IWebElement btnPesquisar()
        {
            return driver.FindElement(By.Name("submit_search"));
        }


        public IWebElement btnAbrirModoLista()
        {
            return driver.FindElement(By.CssSelector(".icon-th-list"));
        }

        public IWebElement linkSelecionarProduto()
        {
            return driver.FindElement(By.CssSelector("#center_column > ul > li:nth-child(1) > div > div > div.center-block.col-xs-4.col-xs-7.col-md-4 > h5 > a"));
        }


        public IWebElement abrirMenuDepartamento()
        {
            return driver.FindElement(By.CssSelector("a[title='Women']"));
        }



        public IWebElement colocarItemNoCarrinho()
        {
            return driver.FindElement(By.XPath("//span[contains(.,'Add to cart')]"));
        }

        public IWebElement checarItemNocarrinho()
        {
            return driver.FindElement(By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_product.col-xs-12.col-md-6 > h2 > i"));
        }


        public IWebElement clicarSignIn()
        {
            return driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a"));
        }
    }
}
