using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;


//sales model to dto to the front end.
namespace salesapi.Models
{
    public class SalesModel
    {
        public string Name {get; set;} = string.Empty;
        public int Amount {get; set;}
        public string Date {get; set; } = string.Empty;

    }
}