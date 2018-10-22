using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ODataService.Models
{
	public class ProductsContext : DbContext
	{
		public ProductsContext()  : base("name=ProductsContext")
		{
		}
		public DbSet<Product> Products { get; set; }

	}
}