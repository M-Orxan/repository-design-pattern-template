using RepositoryDesignPatternExample.Models;

namespace RepositoryDesignPatternExample.Repositories
{
    public interface IProductRepository
    {

        IEnumerable<Product> GetAll();

        void Insert(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product GetById(int productId);
        void Save();
    }
}
