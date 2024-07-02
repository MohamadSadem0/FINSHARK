using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stocks
    {
        public int Id { get; set; }
        public string Symbol { get; set; }=string.Empty;
        public string CompanyName { get; set; }=string.Empty;
        [column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }
    }
}