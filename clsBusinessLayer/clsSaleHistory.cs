using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsDataAccess;
using Models;

namespace clsBusinessLayer
{
    public class clsSaleHistory
    {

        public static List<clsSaleHistoryModel> GetAllSales()
        {
            return clsSaleHistoryData.GetAllSales();
        }
        public static List<clsSaleItemHistoryModel> GetSaleItemsBySaleID(int saleID)
        {
            if(saleID<0)
            {
                return new List<clsSaleItemHistoryModel>();
            }

            return clsSaleHistoryData.GetSaleItemsBySaleID(saleID);
        }

    }
}
