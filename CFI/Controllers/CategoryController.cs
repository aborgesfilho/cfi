using CFI.DB;
using CFI.Models;
using CFI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using CFI.Interfaces;

namespace CFI.Repositories
{
    public class CategoryController : ICategoryController
    {
        private readonly DbSession db;
        public CategoryController(DbSession dbSession)
        {

            if (dbSession.Connection.ConnectionString.Trim() == "")
                dbSession.Connection.ConnectionString = dbSession.ConnectionString;
            db = dbSession;
        }

        public List<Category> GetAllCategoryData()
        {
            string query = "";

            if (db.Connection.ConnectionString.Trim() == "")
                db.Connection.ConnectionString = db.ConnectionString;

            query += "SELECT * ";
            query += " FROM Category ORDER BY 1 ";

            using (var conn = db.Connection)
            {
                List<Category> lstCategory = conn.Query<Category>(sql: query).AsList<Category>();
                return lstCategory;
            }
        }

        public int UpdateCategory(Category category)
        {
            int returnValue = 0;
            string query = "";

            if (db.Connection.ConnectionString.Trim() == "")
                db.Connection.ConnectionString = db.ConnectionString;


            query += "UPDATE Category SET ";
            query += " MinimumValue = @MinimumValue, ";
            query += " MaximumValue = @MaximumValue, ";
            query += " Code = @Code, ";
            query += " Description = @Description ";
            query += " WHERE CategoryId = @CategoryId ";

            using (var conn = db.Connection)
            {
                returnValue = conn.Execute
                    (
                        sql: query, param: new
                        {
                            MinimumValue = category.MinimumValue,
                            MaximumValue = category.MaximumValue,
                            Code = category.Code,
                            Description = category.Description,
                            CategoryId = category.CategoryId
                        }
                    );
            }

            return returnValue;

        }

        public int InsertCategory(Category category)
        {
            int returnValue = 0;
            string query = "";

            if (db.Connection.ConnectionString.Trim() == "")
                db.Connection.ConnectionString = db.ConnectionString;


            query += "INSERT INTO Category VALUES (";
            query += " @MinimumValue, ";
            query += " @MaximumValue, ";
            query += " @Code, ";
            query += " @Description) ";

            using (var conn = db.Connection)
            {
                returnValue = conn.Execute
                    (
                        sql: query, param: new
                        {
                            MinimumValue = category.MinimumValue,
                            MaximumValue = category.MaximumValue,
                            Code = category.Code,
                            Description = category.Description,
                        }
                    );
            }

            return returnValue;

        }

        public void DeleteCategory(int categoryId)
        {
            string query = "";

            if (db.Connection.ConnectionString.Trim() == "")
                db.Connection.ConnectionString = db.ConnectionString;


            query += "DELETE FROM Category ";
            query += " WHERE CategoryId = @CategoryId ";

            using (var conn = db.Connection)
            {
                var returnValue = conn.Execute(sql: query, param: new { CategoryId = categoryId });
            }


        }

    }
}
