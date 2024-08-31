using System;
using System.Collections.Generic;

namespace Entities
{



    public partial class Product
    {
        public int ProdId { get; set; }
        public string? ProdName { get; set; }
        public int? Price { get; set; }
        public DateTime? ExpDate { get; set; }
        public int? ProdCount { get; set; }
        public int? CatId { get; set; }

        public virtual Category? Cat { get; set; }
    }
}
