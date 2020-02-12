using QuieroPizza.BL;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productosBL = new ProductosBL();
            var productos = productosBL.ObtenerProductos();

            return View(productos);
        }
    }
}