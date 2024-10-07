using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuraSkinDTO
{
    internal class Orders
    {
        private string id {  get; set; }
        private string userID { get; set; }
        private string customerID { get; set; }
        private DateTime date { get; set; }
        private double total {  get; set; }
        private string customerShipmentID {  get; set; }
        private string orderStatusID {  get; set; }
    }
}
