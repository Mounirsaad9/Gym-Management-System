using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class clsProductModel
    {

        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int StockQuantity { get; set; }
        public int MinStockAlert { get; set; }
        public string BarcodeValue { get; set; }   // ممكن تكون null
        public bool IsActive { get; set; }

    }
}
