using CadastroPacientes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroPacientes.Controllers
{
    public class PacienteController : Controller
    {

        private readonly ILogger<PacienteController> _logger;

        public PacienteController(ILogger<PacienteController> logger)
        {
            _logger = logger;
        }

        private static IList<Paciente> pacientes =
            new List<Paciente>()
            {
                new Paciente()
                {
                    PacienteID = 1,
                    Nome = "Thiago",
                    Telefone = "99999-9999",
                    Modalidade = "Fisioterapia",
                    Email = "thiago@gmail.com",
                    Endereco = "Rua Itororo",
                    DataNascimento = "04/12/1986",
                    Diagnostico = "Condromalacia",
                    QueixaPrincipal = "Dor"
                }
            };
        // GET: PacienteController
        public ActionResult Index()
        {
            return View(pacientes.OrderBy(i => i.PacienteID));
        }

        // GET: PacienteController/Details/5
        public ActionResult Details(long id)
        {
            return View(pacientes.Where(i => i.PacienteID == id).First());
        }

        // GET: PacienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Paciente paciente)
        {
            pacientes.Add(paciente);
            paciente.PacienteID = pacientes.Select(i => i.PacienteID).Max() + 1;
            return RedirectToAction("Index");
        }

        // GET: PacienteController/Edit/5
        public ActionResult Edit(long id)
        {
            return View(pacientes.Where(i => i.PacienteID == id).First());
        }

        // POST: PacienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Paciente paciente)
        {
            pacientes.Remove(pacientes.Where(i => i.PacienteID == paciente.PacienteID).First());
            pacientes.Add(paciente);
            return RedirectToAction("Index");
        }

        // GET: PacienteController/Delete/5
        public ActionResult Delete(long id)
        {
            return View(pacientes.Where(i =>i.PacienteID == id).First());

        }

        // POST: PacienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Paciente paciente)
        {
            pacientes.Remove(pacientes.Where(i => i.PacienteID == paciente.PacienteID).First());
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
