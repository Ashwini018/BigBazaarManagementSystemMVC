using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBazaarDL
{
    public class BigBazaarD : IBigBazaarDL
    {
        private readonly BigBazaarContext context;

        public BigBazaarD(BigBazaarContext context)
        {
            this.context = context;
        }
        public async Task<bool> AddCategory(Category category)
        {
            try
            {
                int row = 0;

                context.Categories.Add(category);

                row = await context.SaveChangesAsync();
                if (row > 0)
                {
                    return true;
                }
                else 
                { 
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
        }

        public Task<bool> AddProduct(Product prod)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetCategories()
        {
            try
            {
                List<Category> list = new List<Category>();

                list =  context.Categories.ToList();

                return list;
            }
            catch(Exception e)
            {
                throw new Exception("Something went wrong!!", e);
            }
        }
    }
}
