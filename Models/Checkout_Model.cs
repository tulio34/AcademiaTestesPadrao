using AcademiaDeTestes.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AcademiaDeTestes.Models
{
    public class Checkout_Model
    {
        private IWebDriver driver;
        private Checkout_Page checkout;


        public Checkout_Model(IWebDriver superDriver)
        {
            driver = superDriver;
            checkout = new Checkout_Page(driver);
        }


        public void finalizarCompra()
        {
            
            checkout.irParaCheckout1().Click();
            checkout.irParaCheckout2().Click();
            checkout.irParaCheckout3().Click();
            checkout.aceitarTermos().Click();
            checkout.irParaCheckout4().Click();
            checkout.irParaCheckout5().Click();
            checkout.irParaCheckout6().Click();

        }


    }
}