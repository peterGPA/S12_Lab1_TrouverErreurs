using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mission.Data;
using Mission.ViewModels;
using Mission.Models;

namespace Mission.Controllers
{
    public class ProduitsController : Controller
    {
        private readonly MissionDbContext _context;

        public ProduitsController(MissionDbContext context)
        {
            _context = context;
        }

        // GET: Produits
        public async Task<IActionResult> Index()
        {
            // COMPLÉTER ICI
            var produits = await _context.Produits.Include(p => p.Categorie).ToListAsync();
            return View(produits);
        }

    }
}
