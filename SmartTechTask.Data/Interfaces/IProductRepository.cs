using SmartTechTask.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTechTask.Data.Interfaces
{
    public interface IProductRepository
    {
        Product Add(Product product);

        void Edit(Product product);

        void Remove(int id);

        IEnumerable<Product> GetAll();
    }
}
