using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApp
{
	class Program
	{

		// Get an entire entity set.
		static void ListAllProducts(Default.Container container)
		{
			
			foreach (var p in container.Products)
			{
				Console.WriteLine("{0} {1}", p.Name, p.ID);
			}
		}

		static void AddProduct(Default.Container container, ODataService.Models.Product product)
		{
			container.AddToProducts(product);
			var serviceResponse = container.SaveChanges();
			foreach (var operationResponse in serviceResponse)
			{
				Console.WriteLine("Response: {0}", operationResponse.StatusCode);
			}
		}

		static void Main(string[] args)
		{

			// TODO: Replace with your local URI.
			string serviceUri = "http://localhost:57191/";
			var container = new Default.Container(new Uri(serviceUri));

			var product = new ODataService.Models.Product()
			{
				Name = "Dave",
				ID = 12
			};

			AddProduct(container, product);

			ListAllProducts(container);

			Console.WriteLine("Done");

			Console.ReadLine();
		}
	}
}
