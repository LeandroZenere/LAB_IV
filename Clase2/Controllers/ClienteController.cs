using Clase2.Models;
using Clase2.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2.Controllers
{
    public class ClienteController : Controller
    {
        // GET: ClienteController
        public ActionResult Index()
        {
            var cliente = new List<Cliente>()
            {
            new Cliente {Nombre= "Leandro Zénere"},
            new Cliente { Nombre = "Zénere Leandro" }
            };
            var producto = new List<Producto>()
            {
            new Producto {Descripcion= "Fernet"},
            new Producto {Descripcion = "Cerveza" }
            }; 

            var clienteViewModel = new ClienteViewModel
            {
            Cliente = cliente,
            Producto = producto
            };
            return View(clienteViewModel);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            //var cliente = new ClienteController {IdCliente = 1, }
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
