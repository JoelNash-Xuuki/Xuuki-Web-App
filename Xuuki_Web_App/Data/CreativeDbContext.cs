using Creative.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data
{
	public class CreativeDbContext : DbContext
	{
		public CreativeDbContext (DbContextOptions<CreativeDbContext> options) : base(options){} 

		public DbSet<CreativeModel> CreativeModel { get; set;}
	}
}
