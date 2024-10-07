using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraSkinDTO
{
    internal class ProductVariants
    {
        private string id {  get; set; }
        private string productID {  get; set; }
        private string variantName {  get; set; }
        private string imageID { get; set; }
        private int stockQuantity {  get; set; }
    }
}
