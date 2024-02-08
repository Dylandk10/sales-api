using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace salesapi.Models
{
    public class OrderModel
    {
        public string OrderNumber {get; set;} = string.Empty;
        public string Revenue {get; set;} = string.Empty;
        public int NumberOfOrders {get; set;}
        public string Date {get; set; } = string.Empty;
    }
}