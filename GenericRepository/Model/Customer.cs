using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Model
{
    public class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string mail { get; set;  }
        public int phone { get; set; }
        
        public Product Product { get; set; }

    }
}
