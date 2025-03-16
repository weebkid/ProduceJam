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
    [ApiController]
    [Route("[controller]")]
    public class ShoppingListObjectsController : Controller
    {
        private readonly ProduceJamContext _context;

        public ShoppingListObjectsController(ProduceJamContext context)
        {
            _context = context;
        }



        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,ShoppingDate,Items,Price")] ShoppingListObject shoppingListObject)
        {
            _context.Add(shoppingListObject);
            await _context.SaveChangesAsync();
            return Ok(shoppingListObject);
        }

        [HttpGet]
        [Route("User")]

        public async Task<IActionResult> GetUserLists(string User)
        {
           List<ShoppingListObject> lists= await _context.ShoppingListObject.Where(o =>  o.User == User).ToListAsync();
            return Ok(lists);
        }

        [HttpGet]
        public async Task<IActionResult> GetList(int Id)
        {
            
            ShoppingListObject? list = await _context.ShoppingListObject.FirstOrDefaultAsync(l => l.Id == Id);
            if (list == null) return NotFound();
            return Ok(list);

        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var obj = _context.ShoppingListObject.Find(Id);

            if (obj == null) return NotFound();
            _context.ShoppingListObject.Remove(obj);

            await _context.SaveChangesAsync();
            return Ok(obj);
        }
        
    }
}
