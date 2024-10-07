using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraSkinDTO
{
    internal class OrderItems
    {
        private string id { get; set; }
        private string orderID { get; set; }
        private string productVariantID {  get; set; }
        private int quantity {  get; set; }
        private double price {  get; set; }
    }
}
