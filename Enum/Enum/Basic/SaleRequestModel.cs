
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample.Basic
{
    public class SaleRequestModel
    {
        public double Total { get; set; }
        public string InvoiceNumber { get; set; }
        public string[] SaleDetailType { get; set; } = new string[] { "All" };
    }
}
