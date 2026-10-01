using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsDataAccess;
using Models;

namespace clsBusinessLayer
{
    public class clsProduct
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enum enSaveResult
        {
            Success,
            DuplicateName,
            InvalidPurchasePrice,
            InvalidPrice,
            SellingLessThanPurchase, 
            InvalidStock,
            Failed
        }

        private enMode _Mode = enMode.AddNew;
        private clsProductModel _Product = new clsProductModel();

        public clsProductModel ProductData
        {
            get { return _Product; }
            set { _Product = value; }
        }

        
        public clsProduct()
        {
            _Mode = enMode.AddNew;
        }

        public clsProduct(clsProductModel productModel)
        {
            if (productModel != null)
            {
                _Product = productModel;
                _Mode = enMode.Update;
            }
        }

        
        private enSaveResult _Validation()
        {
            if (string.IsNullOrWhiteSpace(_Product.ProductName))
                return enSaveResult.Failed;

            if (_Product.PurchasePrice <= 0)
                return enSaveResult.InvalidPurchasePrice;

            if (_Product.SellingPrice <= 0)
                return enSaveResult.InvalidPrice;

          
            if (_Product.SellingPrice < _Product.PurchasePrice)
                return enSaveResult.SellingLessThanPurchase;

            if (_Product.StockQuantity < 0 || _Product.MinStockAlert < 0)
                return enSaveResult.InvalidStock;

            
            if (clsProductData.IsProductNameExists(_Product.ProductName, _Product.ProductID))
                return enSaveResult.DuplicateName;

            return enSaveResult.Success;
        }

        private enSaveResult _AddNewProduct()
        {
            enSaveResult validation = _Validation();
            if (validation != enSaveResult.Success)
                return validation;

            _Product.ProductID = clsProductData.AddProduct(
                _Product.CategoryID,
                _Product.ProductName,
                _Product.PurchasePrice,
                _Product.SellingPrice,
                _Product.StockQuantity,
                _Product.MinStockAlert,
                _Product.BarcodeValue);

            return (_Product.ProductID != -1) ? enSaveResult.Success : enSaveResult.Failed;
        }

        private enSaveResult _UpdateProduct()
        {
            enSaveResult validation = _Validation();
            if (validation != enSaveResult.Success)
                return validation;

            bool updated = clsProductData.UpdateProduct(
                _Product.ProductID,
                _Product.CategoryID,
                _Product.ProductName,
                _Product.PurchasePrice,
                _Product.SellingPrice,
                _Product.StockQuantity,
                _Product.MinStockAlert,
                _Product.BarcodeValue);

            return updated ? enSaveResult.Success : enSaveResult.Failed;
        }

        public enSaveResult Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    return _AddNewProduct();
                case enMode.Update:
                    return _UpdateProduct();
            }
            return enSaveResult.Failed;
        }

        public static bool Deactivate(int productID)
        {
            return clsProductData.DeactivateProduct(productID);
        }

        public static List<clsProductModel> GetAllProducts()
        {
            return clsProductData.GetAllProducts();
        }

        public static clsProductModel Find(int productID)
        {
          
            return clsProductData.GetProductByID(productID);
        }
    }
}
