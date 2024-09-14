using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBazaarDL
{
    public interface IBigBazaarDL
    {
        public Task<bool> AddCategory(Category cat);

        public Task<bool> AddProduct(Product prod);

        public Task<List<Category>> GetCategories();
    }
}
