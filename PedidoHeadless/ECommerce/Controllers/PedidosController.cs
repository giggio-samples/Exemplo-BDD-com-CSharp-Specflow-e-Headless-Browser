using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Controllers
{
    public class PedidosController : Controller
    {
        public ActionResult Novo()
        {
            return View();
        }

        public ActionResult Acrescentar(string produto)
        {
            var pedido = new List<string>{produto};
            ViewBag.Pedido = pedido;
            return View("Novo");
        }
    }
}
