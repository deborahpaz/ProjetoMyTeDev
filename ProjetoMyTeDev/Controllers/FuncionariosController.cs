﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoMyTeDev.Data;
using ProjetoMyTeDev.Models;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using System.Text;

namespace ProjetoMyTeDev.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FuncionariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Policy = "RequerPerfilAdmin")]
        // GET: Funcionarios
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var funcionarios = await _context.Funcionario
                               .Include(f => f.Cargo)
                               .Include(f => f.Departamento)
                               .Include(f => f.NivelAcesso)
                               .ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                funcionarios = funcionarios
            .Where(f => RemoveDiacritics(f.FuncionarioNome.ToLower()).Contains(RemoveDiacritics(searchString.ToLower())))
            .ToList();
            }

            return View(funcionarios);
        }

        private static string RemoveDiacritics(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }



        // GET: Funcionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionario
                .Include(f => f.Cargo)
                .Include(f => f.Departamento)
                .Include(f => f.NivelAcesso)
                .FirstOrDefaultAsync(m => m.FuncionarioId == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        [Authorize(Policy = "RequerPerfilAdmin")]
        // GET: Funcionarios/Create
        public IActionResult Create()
        {

            ViewData["CargoId"] = new SelectList(_context.Cargo, "CargoId", "CargoNome");
            ViewData["DepartamentoId"] = new SelectList(_context.Departamento, "DepartamentoId", "DepartamentoNome");
            ViewData["NivelAcessoId"] = new SelectList(_context.NivelAcesso, "NivelAcessoId", "NivelAcessoNome");
            return View();
        }

        // POST: Funcionarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuncionarioId,FuncionarioNome,Email,Senha,DepartamentoId,NivelAcessoId,DataContratacao,Localidade,CargoId")] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {

                _context.Add(funcionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                Console.WriteLine(ModelState);

            }

            ViewData["CargoId"] = new SelectList(_context.Cargo, "CargoId", "CargoNome", funcionario.CargoId);
            ViewData["DepartamentoId"] = new SelectList(_context.Departamento, "DepartamentoId", "DepartamentoNome", funcionario.DepartamentoId);
            ViewData["NivelAcessoId"] = new SelectList(_context.NivelAcesso, "NivelAcessoId", "NivelAcessoNome", funcionario.NivelAcessoId);


            return View(funcionario);
        }

        // GET: Funcionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionario.FindAsync(id);
            if (funcionario == null)
            {
                return NotFound();
            }
            ViewData["CargoId"] = new SelectList(_context.Cargo, "CargoId", "CargoNome", funcionario.CargoId);
            ViewData["DepartamentoId"] = new SelectList(_context.Departamento, "DepartamentoId", "DepartamentoNome", funcionario.DepartamentoId);
            ViewData["NivelAcessoId"] = new SelectList(_context.NivelAcesso, "NivelAcessoId", "NivelAcessoNome", funcionario.NivelAcessoId);
            return View(funcionario);
        }

        // POST: Funcionarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuncionarioId,FuncionarioNome,Email,Senha,DepartamentoId,NivelAcessoId,DataContratacao,Localidade,CargoId")] Funcionario funcionario)
        {
            if (id != funcionario.FuncionarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionarioExists(funcionario.FuncionarioId))
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
            ViewData["CargoId"] = new SelectList(_context.Cargo, "CargoId", "CargoNome", funcionario.CargoId);
            ViewData["DepartamentoId"] = new SelectList(_context.Departamento, "DepartamentoId", "DepartamentoNome", funcionario.DepartamentoId);
            ViewData["NivelAcessoId"] = new SelectList(_context.NivelAcesso, "NivelAcessoId", "NivelAcessoNome", funcionario.NivelAcessoId);
            return View(funcionario);
        }

        // GET: Funcionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funcionario = await _context.Funcionario
                .Include(f => f.Cargo)
                .Include(f => f.Departamento)
                .Include(f => f.NivelAcesso)
                .FirstOrDefaultAsync(m => m.FuncionarioId == id);
            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        // POST: Funcionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funcionario = await _context.Funcionario.FindAsync(id);
            if (funcionario != null)
            {
                _context.Funcionario.Remove(funcionario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionarioExists(int id)
        {
            return _context.Funcionario.Any(e => e.FuncionarioId == id);
        }
    }
}