using System;
using OpenQA.Selenium;

namespace AcademiaDeTestes.Pages
{
    public class Checkout_Page
    {
        private IWebDriver driver;
        public Checkout_Page(IWebDriver superDriver)
        {
            driver = superDriver;
        }



        public IWebElement irParaCheckout1()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //return driver.FindElement(By.XPath("//span[contains(.,'Proceed to checkout')]"));
            return driver.FindElement(By.CssSelector("a[Title = 'Proceed to checkout']"));
            
        }

        public IWebElement irParaCheckout2()
        {
            return driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]"));
        }

        public IWebElement irParaCheckout3()
        {
            return driver.FindElement(By.XPath("//*[@id='center_column']/form/p/button"));
        }

        public IWebElement aceitarTermos()
        {
            return driver.FindElement(By.Id("cgv"));
        }

        public IWebElement irParaCheckout4()
        {
            return driver.FindElement(By.XPath("//*[@id='form']/p/button"));
        }

        public IWebElement irParaCheckout5()
        {
            return driver.FindElement(By.XPath("//*[@id='HOOK_PAYMENT']/div[1]/div/p/a"));
        }

        public IWebElement irParaCheckout6()
        {
            return driver.FindElement(By.XPath("//*[@id='cart_navigation']/button"));
        }

    }
}