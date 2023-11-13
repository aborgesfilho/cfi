using CFI.Models;
using CFI.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFI.Repositories.Interfaces
{
    interface ICategoryController
    {
        List<Category> GetAllCategoryData();
        int UpdateCategory(Category category);
        int InsertCategory(Category category);

        void DeleteCategory(int categoryId);
    }
}
