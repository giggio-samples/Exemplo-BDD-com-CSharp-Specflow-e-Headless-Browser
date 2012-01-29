using System.Web.Mvc;
using ECommerce.Controllers;
using NUnit.Framework;

namespace Pedido.Specs.Tests
{
    [TestFixture]
    class PedidosControllerTests
    {
        [Test]
        public void DeveAcrescentarOProdutoAoPedido()
        {
            var controller = new PedidosController();
            const string produto = "Brinquedo";
            var viewResult = (ViewResult)controller.Acrescentar(produto);
            Assert.IsTrue(viewResult.ViewBag.Pedido.Contains(produto));
        }
    }
}
