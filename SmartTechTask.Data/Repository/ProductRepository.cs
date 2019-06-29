using SmartTechTask.Data.Entities;
using SmartTechTask.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTechTask.Data.Repository
{
    public class ProductRepository : IProductRepository
    {

        private ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public Product Add(Product product)
        {
            product = _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void Edit(Product product)
        {
            Product oldProduct = _context.Products.FirstOrDefault(f => f.Id == product.Id);
            if(oldProduct != null)
            {
                oldProduct.Name = product.Name;
                oldProduct.Price = product.Price;
                oldProduct.Photo = product.Photo;
                oldProduct.LastUpdated = product.LastUpdated;
                _context.Entry<Product>(oldProduct).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public void Remove(int id)
        {
            Product product = _context.Products.FirstOrDefault(f => f.Id == id);
            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
