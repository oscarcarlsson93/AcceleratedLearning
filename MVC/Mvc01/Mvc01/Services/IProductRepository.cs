using Mvc01.Models;
using System.Collections.Generic;

namespace Mvc01.Services
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
    }
}