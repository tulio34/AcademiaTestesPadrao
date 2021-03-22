using AcademiaDeTestes.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AcademiaDeTestes.Models
{
    public class Cadastro_Model
    {
        private IWebDriver driver;
        private Cadastro_Page cadastro;


        public Cadastro_Model(IWebDriver superDriver)
        {
            driver = superDriver;
            cadastro = new Cadastro_Page(driver);
        }


        public void preencherFormularioCriarUsuario(String sPrimeiroNome, string sSobrenome, string sSenha, string sEndereco, string sCidade, string sCodigoPostal, string sTelefoneCelular)
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            //Assert.IsTrue(cadastro.radioGender2().Displayed);
            cadastro.radioGender2().Click();
            cadastro.inputPreencherPrimeiroNome().SendKeys(sPrimeiroNome);
            cadastro.inputPreencherSobrenome().SendKeys(sSobrenome);
            cadastro.inputPreencherSenha().SendKeys(sSenha);
            cadastro.inputPreencherEndereco().SendKeys(sEndereco);
            cadastro.inputCidade().SendKeys(sCidade);
            cadastro.inputEstado().Click();
            cadastro.inputEstado().Selected.Equals("Georgia");
            cadastro.inputCodigoPostal().SendKeys(sCodigoPostal);
            cadastro.inputTelefoneCelular().SendKeys(sTelefoneCelular);
            cadastro.btnConfirmarCriacaoUsuario().Click();
         
        }


    }
}