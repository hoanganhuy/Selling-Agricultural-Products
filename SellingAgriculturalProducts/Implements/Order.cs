using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingAgriculturalProducts.Implements
{
    public class Order
    {
        //attributes
        #region
        public int orderId { get; set; } = -1;
        public int customerId { get; set; } = -1;
        public int totalAmount { get; set; } = -1;
        public float totalPrice { get; set; } = -1;
        public List<Product> productList { get; set; }
        #endregion
    }
}