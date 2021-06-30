using EnumExample.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public static class Data
    {
        public static List<SaleViewModel> GeSalesData()
        {
            var data = new List<SaleViewModel>{ 
                new SaleViewModel {Id="",InvoiceNumber="Inv-2021",SaleDetailType =  EnumsData.SaleDetailType.Sale,Total = 25000 },
                new SaleViewModel {Id="",InvoiceNumber="Inv-2026",SaleDetailType =  EnumsData.SaleDetailType.Return,Total = 15000 },
                new SaleViewModel {Id="",InvoiceNumber="Inv-2022",SaleDetailType =  EnumsData.SaleDetailType.Damage,Total = 85000 },
                new SaleViewModel {Id="",InvoiceNumber="Inv-2023",SaleDetailType =  EnumsData.SaleDetailType.Return,Total = 75000 },
                new SaleViewModel {Id="",InvoiceNumber="Inv-2024",SaleDetailType =  EnumsData.SaleDetailType.Gift,Total = 65000 },
                new SaleViewModel {Id="",InvoiceNumber="Inv-2021",SaleDetailType =  EnumsData.SaleDetailType.Sale,Total = 55000 },
                new SaleViewModel {Id="",InvoiceNumber="Inv-2025",SaleDetailType =  EnumsData.SaleDetailType.Gift,Total = 35000 },
                new SaleViewModel {Id="",InvoiceNumber="Inv-2026",SaleDetailType =  EnumsData.SaleDetailType.Sale,Total = 45000 },
            };
            return data;
        }
    }
}
