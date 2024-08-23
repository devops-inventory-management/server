using DevOpsInventoryManagement.DAL.Interfaces;
using DevOpsInventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevOpsInventoryManagement.DAL.Repositories
{
    public class ProductRepository : BaseRepository<Product, string>, IProductRepository
    {

        public IEnumerable<Product> GetAll()
        {
            return _products.ToList();
        }

        public Product? GetById(int id)
        {
            return _products.Find(id);
        }

        public int Count()
        {
            return _products.Count();
        }

        public int Create(Product product)
        {
            _products.Add(product);
            _context.SaveChanges();
            return product.Id;
        }

        public bool Update(int id, Product product)
        {
            var existingProduct = _products.Find(id);
            if (existingProduct == null)
                return false;

            _context.Entry(existingProduct).CurrentValues.SetValues(product);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var product = _products.Find(id);
            if (product == null)
                return false;

            _products.Remove(product);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<Product> GetProductsByName(string name)
        {
            return _products.Where(p => p.Name.Contains(name)).ToList();
        }

        public IEnumerable<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return _products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public IEnumerable<Product> GetProductsWithLowStock(int threshold)
        {
            return _products.Where(p => p.StockQuantity < threshold).ToList();
        }
    }
}