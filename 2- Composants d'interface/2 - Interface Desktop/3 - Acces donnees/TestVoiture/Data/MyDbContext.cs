using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestVoiture.Data.Models;

namespace TestVoiture.Data
{
    public class MyDbContext:DbContext
    {
        public DbSet<Voiture> Voitures { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }
}
