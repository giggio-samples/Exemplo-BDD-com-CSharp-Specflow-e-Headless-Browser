using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Pedido.Specs.Features.Support;
using TechTalk.SpecFlow;

namespace Pedido.Specs.Features.StepsDefinition
{
    [Binding]
    public class AcrescentarProdutosAoPedidoSteps : BaseStep
    {
        [Given(@"um pedido novo")]
        public void DadoUmPedidoNovo()
        {
            FF.Navigate().GoToUrl("http://localhost:5555/Pedidos/Novo");
        }
        [When(@"eu acrescento o produto (.*)")]
        public void QuandoEuAcrescentoOProduto(string produto)
        {
            FF.FindElementByName("produto").SendKeys(produto);
            FF.FindElementById("acrescentar").Click();
        }
        [Then(@"o produto ""(.*)"" aparece no pedido")]
        public void EntaoOProdutoApareceNoPedido(string produto)
        {
            FF.FindElementByName("produto").GetAttribute("value").Should().BeNullOrEmpty();
            FF.PageSource.Contains(produto).Should().BeTrue();
        }
        [Then(@"o produto ""(.*)"" não aparece no pedido")]
        public void ThenOProdutoNaoApareceNoPedido(string produto)
        {
            FF.PageSource.Contains(produto).Should().BeFalse();
        }



    }
}
