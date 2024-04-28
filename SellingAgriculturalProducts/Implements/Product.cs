using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingAgriculturalProducts.Implements
{
    public class Product
    {
        //attributes
        #region
        public int productId { get; set; } = -1;
        public int categoryId { get; set; } = -1;
        public string productName { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public float price { get; set; } = -1;
        #endregion
    }
}