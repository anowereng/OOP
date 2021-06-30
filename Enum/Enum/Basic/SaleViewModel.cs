
using EnumsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample.Basic
{
    public class SaleViewModel
    {
        public string Id { get; set; }
        public double Total { get; set; }
        public string InvoiceNumber { get; set; }   
        public SaleDetailType SaleDetailType { get; set; }
    }
}
