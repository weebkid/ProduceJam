using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using ProduceJam.Models;

namespace ProduceJam.Data
{
    public class ProduceJamContext : DbContext
    {
        public ProduceJamContext (DbContextOptions<ProduceJamContext> options)
            : base(options)
        {

        }

        public DbSet<ProduceJam.Models.ShoppingListObject> ShoppingListObject { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {        }
        public DbSet<ProduceJam.Models.LastWeek> LastWeek { get; set; } = default!;
    }
}
