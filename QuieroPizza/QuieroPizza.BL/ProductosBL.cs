using System.Collections.Generic;
using System.Linq;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public ProductosBL()
        {
            _contexto = new Contexto();
        }

        public List<Producto> ObtenerProductos()
        {
            return _contexto.Productos.ToList();
        }
    }
}
