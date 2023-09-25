using Microsoft.AspNetCore.Mvc;
using OnlineStore.DAL.Interfaces;
using OnlineStore.Domain.Entity;

namespace OnlineStore.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductController: ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<List<Product>> GetAllProducts() { 
            return await _productRepository.GetAllEntities();
        }
    }
}
