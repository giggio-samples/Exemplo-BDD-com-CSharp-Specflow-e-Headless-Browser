using FluentAssertions;
using Pedido.Specs.Features.Support;
using SimpleBrowser;
using TechTalk.SpecFlow;

namespace Pedido.Specs.Features.StepsDefinition
{
    [Binding]
    public class AcrescentarProdutosAoPedidoSteps : BaseStep
    {
        [Given(@"um pedido novo")]
        public void DadoUmPedidoNovo()
        {
            Browser.Navigate("http://localhost:5555/Pedidos/Novo");
        }
        [When(@"eu acrescento o produto (.*)")]
        public void QuandoEuAcrescentoOProduto(string produto)
        {
            Browser.Find(ElementType.TextField, "name", "produto").Value = produto;
            Browser.Find(ElementType.Button, "id", "acrescentar").Click();
        }
        [Then(@"o produto ""(.*)"" aparece no pedido")]
        public void EntaoOProdutoApareceNoPedido(string produto)
        {
            Browser.Find(ElementType.TextField, "name", "produto").Value.Should().BeNullOrEmpty();
            Browser.ContainsText(produto).Should().BeTrue();
        }
        [Then(@"o produto ""(.*)"" não aparece no pedido")]
        public void ThenOProdutoNaoApareceNoPedido(string produto)
        {
            Browser.ContainsText(produto).Should().BeFalse();
        }



    }
}
