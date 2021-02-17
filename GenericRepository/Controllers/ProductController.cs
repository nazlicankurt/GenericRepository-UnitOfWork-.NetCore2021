
using GenericRepository.Data;
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
    public class ProductController : ControllerBase
    {
        private IProductRepository productRepository;
        private IUnitOfWork uow;

        public ProductController(IProductRepository pRepo, IUnitOfWork unitOfWork)
        {
            productRepository = pRepo;
            uow = unitOfWork;
        }


        // GET: api/dev
        [HttpGet]
        public ActionResult GetAll()
        {
            var list = productRepository.All();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public ActionResult GetValue(int id)
        {
            var product = productRepository.Get(id);
            if (product is null) return NotFound();

            return Ok(product);


        }

        [HttpPost]
        public ActionResult Post(Product p)
        {
            productRepository.Add(p);
            uow.Save();
            return Ok();
        }

        // PUT 
        [HttpPut("{id}")]
        public void Put(Product p)
        {
            productRepository.Update(p);
            uow.Save();

        }

        // DELETE 
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            productRepository.Delete(id);
            uow.Save();

            return Ok();

        }

    }
}
