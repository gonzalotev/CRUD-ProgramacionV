using CrudGatitos.Data;
using CrudGatitos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudGatitos.Controllers
{
    public class GatitosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GatitosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Gatito> listGatito = _context.Gatito;
            return View(listGatito);
        }

        //Http Get Create
        public IActionResult Create()
        {
            return View();
        }

        //Http Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Gatito gatito)
        {
            if (ModelState.IsValid){
                _context.Gatito.Add(gatito);
                _context.SaveChanges();

                TempData["mensaje"] = "El Gatito se ha registrado con exito!";
                return RedirectToAction("Index");
            }

            return View();
        }

        //Http Get Edit
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) {
                return NotFound();
            }

            //obtener gatito
            var gatito = _context.Gatito.Find(id);

            if (gatito == null){
                return NotFound();
            }

            return View(gatito);
        }

        //Http Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Gatito gatito)
        {
            if (ModelState.IsValid)
            {
                _context.Gatito.Update(gatito);
                _context.SaveChanges();

                TempData["mensaje"] = "Los datos del Gatito se han modificado con exito!";
                return RedirectToAction("Index");
            }

            return View();
        }

        //Http Get Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //obtener gatito
            var gatito = _context.Gatito.Find(id);

            if (gatito == null)
            {
                return NotFound();
            }

            return View(gatito);
        }

        //Http Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteGatito(int? id)
        {
            //obtener id del gatito
            var gatito = _context.Gatito.Find(id);

            if(gatito == null)
            {
                return NotFound();
            }

            _context.Gatito.Remove(gatito);
            _context.SaveChanges();

            TempData["mensaje"] = "Los datos del Gatito se han eliminado con exito!";
            return RedirectToAction("Index");

        }
    }
}
