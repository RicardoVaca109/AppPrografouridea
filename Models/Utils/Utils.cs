namespace WebApplication1.Models.Utilies
{
    public class Utils
    {
        static public List<Producto> ListaProductos = new List<Producto>()
        {
            new Producto
            {
                IdProducto = 1,
                Nombre = "p1",
                Descripcion = "D1",
                Precio = 2.04,
                CantidadStock = 4,
                IdProveedor = 1,
            },

            new Producto
            {
                IdProducto = 2,
                Nombre = "p2",
                Descripcion = "D2",
                Precio = 5.60,
                CantidadStock = 78,
                IdProveedor = 2,
            },

            new Producto
            {
                IdProducto = 3,
                Nombre = "p3",
                Descripcion = "D3",
                Precio = 10.94,
                CantidadStock = 45,
                IdProveedor = 3,
            },

        };
    }
}
