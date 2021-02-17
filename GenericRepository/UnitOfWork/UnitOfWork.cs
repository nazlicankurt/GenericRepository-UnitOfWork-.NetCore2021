using GenericRepository.Data;

namespace GenericRepository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductContext _productContext;
        public UnitOfWork(ProductContext productContext)
        {
            _productContext = productContext;
        }       

        public void Save()
        {
            _productContext.SaveChanges();
        }
    }
}
