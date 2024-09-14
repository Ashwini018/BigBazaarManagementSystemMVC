using BigBazaarDL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBazaarBL
{
    public class BigBazaarB:IBigBazaarBL
    {
        private readonly IBigBazaarDL context;

        public BigBazaarB(IBigBazaarDL _context)
        {
            this.context= _context;
        }

        public async Task<bool> AddCategory(Category category)
        {
            try
            {
                return (await context.AddCategory(category));
            }
            catch(Exception ex)
            {
                throw new Exception("Somethis is wrong!!",ex);
            }
        }

        public async Task<List<Category>> GetCategories()
        {
            try
            {
                return await context.GetCategories();
            }
            catch(Exception e)
            {
                throw new Exception("Something went wrong!!",e);
            }
            
        }
    }
}
