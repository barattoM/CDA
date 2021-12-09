using Api.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Api
{
	public class MyDbContext: DbContext
	{
		public DbSet<Personne> Personnes { get; set; }
		public MyDbContext(DbContextOptions<MyDbContext> options) :base(options)
		{

		}
	}
}

