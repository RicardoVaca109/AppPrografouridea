using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Utilies;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ProductoController : Controller
    {

        private readonly IApiService _apiService;

        public ProductoController(IApiService apiService)
        {
            _apiService = apiService;
        }   


        // GET: ProductoController  
        public async Task<IActionResult> Index()
        {
            try
            {
                List<Producto> productos = await _apiService.obtenerProductos();
                return View(productos);
            } catch (Exception e)
            {
                return View(new List<Producto>());
            }
        }

        // GET: ProductoController/Details/5
        public async Task<ActionResult> Details(int IdProducto)
        {
            var producto = await _apiService.obtenerProducto(IdProducto);
            if (producto != null)
            {
                return View(producto);
            }
            return RedirectToAction("Index");
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        public async Task<IActionResult> Create(Producto producto)
        {
            var pCreado = await _apiService.añadirProducto(producto);
            if (pCreado)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: ProductoController/Edit/5
        public async Task<IActionResult> Edit(int IdProducto)
        {
            var pEditar = await _apiService.obtenerProducto(IdProducto);
            if (pEditar != null)
            {
                return View(pEditar);
            }
            return RedirectToAction("Index");
        }

        // POST: ProductoController/Edit
        [HttpPost]
        public async Task<IActionResult> Edit(Producto producto)
        {
            var pAEditar = await _apiService.actualizarProducto(producto.IdProducto, producto);
            if (pAEditar != null)
            {
                return RedirectToAction(nameof(Index));
            }   
            return View(pAEditar);  
        }


        // GET: ProductoController/Delete/5
        public ActionResult Delete(int IdProducto)
        {
            var producto = _apiService.eliminarProducto(IdProducto);
            return RedirectToAction(nameof(Index));

        }

    }
}
