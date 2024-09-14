using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBazaarBL
{
    public interface IBigBazaarBL
    {
        public Task<bool> AddCategory(Category cat);

        public Task<List<Category>> GetCategories();
    }
}
