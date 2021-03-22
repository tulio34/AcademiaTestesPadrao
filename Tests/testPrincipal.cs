using AcademiaDeTestes.Abstracoes;
using AcademiaDeTestes.Models;
using AcademiaDeTestes.Pages;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaDeTestes.Tests
{
    public class testPrincipal : SuperClass
    {
        private HomePage_Model home;
        private Cadastro_Model cadastro;
        private Checkout_Model checkout;
        private Login_Model login;

        public testPrincipal() : base()
        {
            home = new HomePage_Model(this.driver);
            cadastro = new Cadastro_Model(this.driver);
            checkout = new Checkout_Model(this.driver);
            login = new Login_Model(this.driver);
        }


        //Realizar uma busca por algum item e abrir um item;
        [Test]
        public void pesquisarEAbrirProduto()
        {
            home.pesquisarProduto("Dress");
            home.selecionarProduto();
        }

        //Realizar a navegação por um departamento e abrir um item;
        [Test]
        public void abrirMenuDepartamento()
        {
            home.AbrirMenuDepartamento();
        }


        //Abrir um item e adicionar no carrinho;
        [Test]
        public void abrirEAdicionarItemCarrinho()
        {
            home.pesquisarProduto("Dress");
            home.selecionarProduto();
            home.colocarNoCarrinho();
        }
       
        //Criar usuário;
        [Test]
        public void criarUsuario()
        {

            string sEmail = Faker.Internet.Email();
            home.acessarPaginaLogin();
            login.novoCadastro(sEmail);
            cadastro.preencherFormularioCriarUsuario("Tulio", "Teste", "123456789", "Rua Tal", "Oreo", "30036", "8888888888");
            login.realizarLogout();

        }


        //Realizar uma compra completa de um produto;
        [Test]
        public void realizarCompraCompleta()
        {
            home.acessarPaginaLogin();
            login.realizarLogin("tulio34@live.com", "123456789");
            abrirEAdicionarItemCarrinho();
            checkout.finalizarCompra();
        }

    }
}

    