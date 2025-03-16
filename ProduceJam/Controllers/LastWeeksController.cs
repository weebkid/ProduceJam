using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProduceJam.Data;
using ProduceJam.Models;

namespace ProduceJam.Controllers
{
    public class LastWeeksController : Controller
    {
        private readonly ProduceJamContext _context;

        public LastWeeksController(ProduceJamContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = _context.LastWeek.ToListAsync();
            return Ok(data);
        }

        [HttpGet]
        public async Task<IActionResult> Get(String Commodity)
        {
            var data = await _context.LastWeek.FirstOrDefaultAsync(o =>  o.Commodity == Commodity);

            if (data == null) return NotFound();

            return Ok(data);
        }
    }
}
