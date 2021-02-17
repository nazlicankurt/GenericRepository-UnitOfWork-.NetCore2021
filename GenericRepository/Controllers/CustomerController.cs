using GenericRepository.Model;
using GenericRepository.Repositories;
using GenericRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController :ControllerBase
    {
        private ICustomerRepository customerRepository;
        private IUnitOfWork uow;

        public CustomerController(ICustomerRepository cRepo, IUnitOfWork unitOfWork)
        {
            customerRepository = cRepo;
            uow = unitOfWork;

        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var cust = customerRepository.All();
            return Ok(cust);
        }

        [HttpPost]
        public ActionResult Post(Customer p)
        {
            customerRepository.Add(p);
            uow.Save();
            return Ok();
        }
        // DELETE 
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            customerRepository.Delete(id);
            uow.Save();

            return Ok();

        }

    }
}
