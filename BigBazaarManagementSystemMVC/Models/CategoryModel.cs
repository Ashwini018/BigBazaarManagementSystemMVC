using System;
using System.Collections.Generic;

namespace BigBazaarManagementSystemMVC.Models
{
    public partial class CategoryModel
    {
        public CategoryModel()
        {
            Products = new HashSet<ProductModel>();
        }

        public int CatId { get; set; }
        public string? CatName { get; set; }

        public virtual ICollection<ProductModel> Products { get; set; }
    }
}
