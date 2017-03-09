using Microsoft.EntityFrameworkCore;
using PNb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNb.Data
{
    public class PNbContext : DbContext
    {
        //DB SETS
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local)\mssqllocaldb;Database=PNb;Trusted_Connection=True;");
        }
    }
}
