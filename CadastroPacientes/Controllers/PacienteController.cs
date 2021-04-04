using CadastroPacientes.Data;
using CadastroPacientes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private readonly IESContext _context;

        public PacienteController(IESContext context)
        {
            this._context = context;
        }


        // GET: PacienteController
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pacientes.OrderBy(c => c.Nome).ToListAsync());
        }

        
        // GET: PacienteController/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes.SingleOrDefaultAsync(m => m.PacienteID == id);

            if(paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }
        
        // GET: PacienteController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PacienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Nome", "Telefone", "Modalidade", "Diagnostio", "Email", "Endereco", "DataNascimento", "Diagnostico", "QueixaPrincipal")] Paciente paciente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(paciente);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Não foi possível inserir os dados.");
            }
            return View(paciente);
        }


        // GET: PacienteController/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes.SingleOrDefaultAsync(m => m.PacienteID == id);

            if (paciente == null)
            {
                return NotFound();
            }
            return View(paciente);
        }

        // POST: PacienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long? id, [Bind("PacienteID", "Nome", "Telefone", "Modalidade", "Diagnostio", "Email", "Endereco", "DataNascimento", "Diagnostico", "QueixaPrincipal")] Paciente paciente)
        {
            if (id != paciente.PacienteID){
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteExists(paciente.PacienteID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }                 
                }
                return RedirectToAction(nameof(Index));              
            }
            return View(paciente);
        }

        private bool PacienteExists(long? id)
        {
            return _context.Pacientes.Any(e => e.PacienteID == id);
        }


        
        // GET: PacienteController/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes.SingleOrDefaultAsync(m => m.PacienteID == id);

            if(paciente == null)
            {
                return NotFound();
            }

            return View(paciente);

        }

        // POST: PacienteController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long? id)
        {
            var paciente = await _context.Pacientes.SingleOrDefaultAsync(m => m.PacienteID == id);
            _context.Pacientes.Remove(paciente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
