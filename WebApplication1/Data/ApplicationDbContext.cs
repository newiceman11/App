using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Nuesta tabla a migrar
        public DbSet<book> books { get; set; }
    }

    //las columnas que conponen dicha tabla
    public class book
    {
      
        public int id { get; set; }

        public string name { get; set; }

        public string description{ get; set; }
    }
}
   
