﻿using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Database
{
	public class PizzaContext : DbContext
	{
		public DbSet<Pizza> Pizze { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=localhost;Database=PizzeriaV1;" +
			"Integrated Security=True;TrustServerCertificate=True");
		}
	}
}
