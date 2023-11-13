using ConsoleApp7.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.DAL
{
    internal class APPDpContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-L4MGE54;database=Aqil104EF;trusted_connection=true;integrated security=true;encrypt=false;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
