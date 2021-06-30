
using EnumExample.Basic;
using EnumsData;
using System;
using System.Collections.Generic;
using System.Linq;
namespace EnumExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var requestModel = new SaleRequestModel() { InvoiceNumber = "2024", SaleDetailType = new string[] { "Gift", "Damage" } };

            var sales = GetSales(requestModel);

            foreach (var item in sales)
            {
                Console.WriteLine("InvoiceNumber: {0}, SaleDetailType: {1}, Amount: {2}", item.InvoiceNumber, EnumService<SaleDetailType>.Name(item.SaleDetailType), item.Total);
            }
        }

        static List<SaleViewModel> GetSales(SaleRequestModel requestModel)
        {
            var saleDetailTypes = EnumService<SaleDetailType>.ConvertRequestModelToEnumArray(requestModel.SaleDetailType);
            var data = Data.GeSalesData();
            var result = data
                         .Where(x => saleDetailTypes.Contains(x.SaleDetailType))
                         .Where(x=>x.InvoiceNumber.Contains(requestModel.InvoiceNumber))
                         .ToList();
            return result;
        }


    }
 
}
