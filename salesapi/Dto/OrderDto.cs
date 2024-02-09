using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace salesapi.Dto
{
    public class OrderDto
    {
        public string OrderNumber {get; set; } = string.Empty;
        public int NumberOfOrders {get; set; }
    }
 }