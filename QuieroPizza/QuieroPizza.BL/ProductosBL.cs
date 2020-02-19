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

        public Producto ObtenerProducto(int id)
        {
            return _contexto.Productos.Find(id);
        }

        public void Guardar(Producto producto)
        {
            if (producto.Id == 0)
            {
                _contexto.Productos.Add(producto);
            }
            else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);

                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Existencia = producto.Existencia;
            }

            _contexto.SaveChanges();
        }
    }
}
