using clsDataAccess;
using DTOs;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace clsBusinessLayer
{
    public class clsSale
    {
        // تم اختصار الـ Enum ليحتوي فقط على الحالات المنطقية الحقيقية للفاتورة
        public enum enSaveResult
        {
            Success,
            EmptyInvoice,
            InsuficientStock,
            Failed
        }

        private clsSaleModel _Sale = new clsSaleModel();
        private List<clsSaleItemModel> _Items = new List<clsSaleItemModel>();

        public clsSaleModel SaleData { get { return _Sale; } }
        public List<clsSaleItemModel> Items { get { return _Items; } }

        public clsSale(int? memberID, int userID, List<clsSaleItemModel> items)
        {
            _Sale.MemberID = memberID; // يقبل null للعميل العابر، أو رقم العضو المحدد
            _Sale.UserID = userID;
            _Items = items;
        }

        public enSaveResult Save()
        {
            if (_Items == null || _Items.Count == 0)
                return enSaveResult.EmptyInvoice;

            if (_Items.Any(i => i.Quantity <= 0))
                return enSaveResult.Failed;
            
            _Sale.TotalAmount = _Items.Sum(i => i.TotalPrice);

            int newSaleID;
            clsSaleData.enSaleDataProduct dalResult = clsSaleData.AddSale(
                _Sale.MemberID,
                _Sale.UserID,
                _Sale.TotalAmount,
                _Items,
                out newSaleID);

            // 4. معالجة النتيجة
            switch (dalResult)
            {
                case clsSaleData.enSaleDataProduct.Success:
                    _Sale.SaleID = newSaleID;
                    return enSaveResult.Success;

                case clsSaleData.enSaleDataProduct.InsufficientStock:
                    return enSaveResult.InsuficientStock;

                default:
                    return enSaveResult.Failed;
            }
        }
    }
}