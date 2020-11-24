using MvcCreative.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MvcCreative.Data
{
	public class MvcCreativeContext : DbContext
	{
		public MvcCreativeContext (DbContextOptions<MvcCreativeContext> options)
			: base(options)
		{
		}
		
		public DbSet<Creative> Creative { get; set;}

	}
}
