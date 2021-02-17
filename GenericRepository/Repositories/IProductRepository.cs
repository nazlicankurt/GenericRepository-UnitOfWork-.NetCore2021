using GenericRepository.Data;
using GenericRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Repositories
{
    public interface IProductRepository :IGenericRepository<Product>
    {
    }

    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext product): base(product)
        { }

    }
}
