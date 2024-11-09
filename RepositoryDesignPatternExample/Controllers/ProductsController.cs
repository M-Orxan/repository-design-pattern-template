using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPatternExample.Models;
using RepositoryDesignPatternExample.Repositories;

namespace RepositoryDesignPatternExample.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);


        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
           
            _productRepository.Insert(newProduct);
            _productRepository.Save();
           return RedirectToAction("Index");
        }

        public IActionResult Update(Product product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int productId)
        {
            _productRepository.Delete(productId);
            _productRepository.Save();
            return RedirectToAction("Index");
        }
    }
}
