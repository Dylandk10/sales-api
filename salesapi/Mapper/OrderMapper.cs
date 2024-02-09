using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using salesapi.Dto;
using salesapi.Models;

namespace salesapi.Mapper
{
    public static class OrderMapper
    {
        public static OrderDto ToOrderDtoNoRevenue(this OrderModel order)
        {
            return new OrderDto {
                OrderNumber = order.OrderNumber,
                NumberOfOrders = order.NumberOfOrders
            };
        }
    }
}