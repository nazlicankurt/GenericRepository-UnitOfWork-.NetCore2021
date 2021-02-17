using GenericRepository.Data;
using GenericRepository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Repositories
{
    public interface ICustomerRepository :IGenericRepository<Customer> 
    {
    }
    public class CustomerRepository : GenericRepository<Customer>,  ICustomerRepository
    {
        public CustomerRepository(ProductContext customer): base(customer)
        { }

    }
}
