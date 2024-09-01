using System;
using System.Collections.Generic;

namespace BigBazaarManagementSystemMVC.Models
{
    public partial class ProductModel
    {
        public int ProdId { get; set; }
        public string? ProdName { get; set; }
        public int? Price { get; set; }
        public DateTime? ExpDate { get; set; }
        public int? ProdCount { get; set; }
        public int? CatId { get; set; }

        public virtual CategoryModel? Cat { get; set; }
    }
}
