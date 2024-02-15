using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC2024.Models;

namespace MVC2024.Controllers
{
    public class VehiculoController : Controller
    {
        public Contexto Contexto { get; }

        public VehiculoController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: VehiculoController
        public ActionResult Index()
        {
            var lista = Contexto.Vehiculos.ToList();
            return View();
        }

        public ActionResult Busqueda(string busca = "")
        {
            ViewBag.buscar = busca;
            var lista = from v in Contexto.Vehiculos.Include(v => v.Serie) where (v.Matricula.Contains(busca)) select v;
            return View(lista);
        }

        public ActionResult Busqueda2(string busca = "")
        {
            ViewBag.busca = new SelectList(Contexto.Vehiculos, "Matricula", "Matricula", busca);
            var lista = from v in Contexto.Vehiculos.Include(v => v.Serie) where (v.Matricula.Equales(busca)) select v;
            return View(lista);
        }

        // GET: VehiculoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehiculoController/Create
        public ActionResult Create()
        {
            ViewBag.SerieId = new SelectList(Contexto.Series, "Id", "NomSerie");
            return View();
        }

        // POST: VehiculoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VehiculoModelo vehiculo)
        {
            try
            {
                Contexto.Marcas.Add(marca);
                Contexto.Database.EnsureCreated();
                Contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehiculoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehiculoController/Edit/5
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

        // GET: VehiculoController/Delete/5
        public ActionResult Delete(int id)
        {
            Contexto.Vehiculos.Find(id);
            return View();
        }

        // POST: VehiculoController/Delete/5
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
