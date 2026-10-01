using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsDataAccess;
using Models;

namespace clsBusinessLayer
{
    public class clsProductCategory
    {

        public enum enMode { AddNew = 0, Update = 1 }

        public enum enSaveResult
        {
            Success,
            DuplicateName,
            Failed
        }

        private enMode _Mode = enMode.AddNew;
        private clsProductCategoryModel _Category = new clsProductCategoryModel();

        public clsProductCategoryModel CategoryData 
        {
            get { return _Category; } 
        }

        
        public clsProductCategory()
        {
            _Mode = enMode.AddNew;
        }

       
        public clsProductCategory(int categoryID, string categoryName)
        {
            _Category.CategoryID = categoryID;
            _Category.CategoryName = categoryName;
            _Mode = enMode.Update;
        }

        private enSaveResult _AddNewCategory()
        {
            if (clsProductCategoryData.IsCategoryNameExists(_Category.CategoryName, 0))
                return enSaveResult.DuplicateName;

            _Category.CategoryID = clsProductCategoryData.AddCategory(_Category.CategoryName);

            return (_Category.CategoryID != -1) ? enSaveResult.Success : enSaveResult.Failed;
        }

        private enSaveResult _UpdateCategory()
        {
            if (clsProductCategoryData.IsCategoryNameExists(_Category.CategoryName, _Category.CategoryID))
                return enSaveResult.DuplicateName;

            bool updated = clsProductCategoryData.UpdateCategory(_Category.CategoryID, _Category.CategoryName);

            return updated ? enSaveResult.Success : enSaveResult.Failed;
        }

        public enSaveResult Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    return _AddNewCategory();
                case enMode.Update:
                    return _UpdateCategory();
            }
            return enSaveResult.Failed;
        }

        public static List<clsProductCategoryModel> GetAllCategories()
        {
            return clsProductCategoryData.GetAllCategories();
        }

    }
}
