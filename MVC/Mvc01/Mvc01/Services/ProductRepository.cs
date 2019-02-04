using Microsoft.AspNetCore.Hosting;
using Mvc01.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc01.Services
{


    public class ProductRepository : IProductRepository
    {
        private IHostingEnvironment _env;
        public ProductRepository(IHostingEnvironment env)
        {
            _env = env;
        }

        public void Add(Product product)
        {
            product.Id = GetAll().Max(x => x.Id) + 1;
            //var list = GetAll();
            //var number = list.Select(x => x.Id.ToString()).ToList();
            //var newnumber = number.OrderBy(x=> x);
            string productstring = $"\n{product.Id},{product.Name},{product.Beskrivning}";
            string root = _env.ContentRootPath;
            string filename = Path.Combine(root, "Data", "products.txt");
            File.AppendAllText(filename, productstring);
        }

        public  List<Product> GetAll()
        {
            string root = _env.ContentRootPath;
            string filename = Path.Combine(root, "Data", "products.txt");
            string[] lines = File.ReadAllLines(filename);
                List<Product> productList = new List<Product>();
            foreach (var x in lines)
            {
                string[] product = x.Split(",");
                productList.Add(new Product { Id = int.Parse(product[0]), Name = product[1], Beskrivning = product[2] });
            }

            return productList;

        }

        public Product GetById(int id)
        {
            return GetAll().Where(x => x.Id == id).Single();
        }
    }
}
