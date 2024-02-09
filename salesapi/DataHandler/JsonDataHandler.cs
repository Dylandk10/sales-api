using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using salesapi.Models;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace salesapi.DataHandler
{
    public class JsonDataHandler
    {
        private readonly List<SalesModel>? _salesData;
        private readonly List<OrderModel>? _orderData;
        public JsonDataHandler() 
        {
            _salesData = this.GetAllSales();
            _orderData = this.GetAllOrders();
        }
        public List<SalesModel>? GetAllSales() 
        {   
            try {
                var path = Path.Combine(Directory.GetCurrentDirectory() +"\\TestData", "testdata.json");
                string text = File.ReadAllText(path);
                
                var salesData = JsonConvert.DeserializeObject<List<SalesModel>>(text);
                return salesData;
            } catch(Exception e) {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<OrderModel>? GetAllOrders() 
        {
            try {
                var path = Path.Combine(Directory.GetCurrentDirectory() +"\\TestData", "orderdata.json");
                string text = File.ReadAllText(path);
                
                var orderData = JsonConvert.DeserializeObject<List<OrderModel>>(text);
                return orderData;
            } catch(Exception e) {
                Console.WriteLine(e);
                return null;
            }
        }


        public List<OrderModel>? OrderedByDate() 
        {

            if(this._orderData == null) 
            {
                return null;
            }

            var sorted = this._orderData.OrderBy(o => o.OrderNumber).ToList();

            return sorted;
        }

        public List<SalesModel>? GetSalesModels() 
        {
            if(this._salesData == null) {
                return null;
            }
            return this._salesData;
        }

        public List<OrderModel>? GetOrderModels() 
        {
            if(this._orderData == null) {
                return null;
            }
            return this._orderData;
        }
    }
}