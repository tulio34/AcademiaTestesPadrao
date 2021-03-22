using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;


namespace AcademiaDeTestes.Abstracoes
{
    public class SuperClass : IDisposable
    {
        protected IWebDriver driver { get; }
        public SuperClass()
        {
            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void Dispose()
        {
            driver?.Quit();
            driver?.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
