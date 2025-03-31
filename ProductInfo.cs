using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoShop
{
    public class ProductInfo
    {
		public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Transmission { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int Quantity {  get; set; }

        public byte[] ProductImage { get; set; }

    }
}
