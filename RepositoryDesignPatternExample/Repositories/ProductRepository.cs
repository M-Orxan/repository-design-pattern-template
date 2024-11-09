using RepositoryDesignPatternExample.Data;
using RepositoryDesignPatternExample.Models;

namespace RepositoryDesignPatternExample.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Delete(int productId)
        {
            var productInDb = _context.Products.Find(productId);

            _context.Products.Remove(productInDb);



        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public void Insert(Product product)
        {
            
            _context.Products.Add(product);

        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product product)
        {
            var productInDb = _context.Products.Find(product.Id);

            productInDb.Name = product.Name;

        }

       
    }
}
