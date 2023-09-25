using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.Interfaces;
using OnlineStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool DeletedEntity(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllEntities()
        {
            return _db.Products.ToListAsync();
        }

        public Product GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Product GetEntity(Product entity)
        {
            throw new NotImplementedException();
        } 
    }
}
