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

        public ActionResult Create()
        {
            var nuevoProducto = new Producto();

            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Create(Producto nuevoProducto)
        {
            var productosBL = new ProductosBL();
            productosBL.Guardar(nuevoProducto);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var productosBL = new ProductosBL();
            var producto = productosBL.ObtenerProducto(id);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            var productosBL = new ProductosBL();
            productosBL.Guardar(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var productosBL = new ProductosBL();
            var producto = productosBL.ObtenerProducto(id);

            return View(producto);
        }

        [HttpPost]
        public ActionResult Delete(Producto producto)
        {
            var productosBL = new ProductosBL();
            productosBL.Eliminar(producto);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var productosBL = new ProductosBL();
            var producto = productosBL.ObtenerProducto(id);

            return View(producto);
        }
    }
}