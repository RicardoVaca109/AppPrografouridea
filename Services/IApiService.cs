using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IApiService
    {
        Task<List<Producto>> obtenerProductos();
        Task<Producto> obtenerProducto(int id);
        Task<bool> añadirProducto(Producto producto);
        Task<bool> actualizarProducto(int id, Producto producto);
        Task<bool> eliminarProducto(int id);
    }
}
