﻿using System;
using System.Data;
using System.Collections.Generic;

using DTO;

namespace DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get => instance = instance ?? new CategoryDAO();
        }

        private CategoryDAO() { }

        public DataTable GetAllCategory()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("select * from CategoryFood");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Category GetCategoryByID(int categoryID)
        {
            Category category = new Category();
            string query = $"select * from CategoryFood where ID = {categoryID}";
            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in table.Rows)
            {
                category = new Category(row);
                return category;
            }
            return category;
        }

        public bool InsertCategory(string name)
        {
            string query = $"insert into CategoryFood (Name) values (N'{name}')";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool UpdateCategory(int id, string name)
        {
            string query = $"update CategoryFood set Name = N'{name}' where ID = {id}";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public bool DeteleCategory(int id)
        {
            string query = string.Format("USP_DeleteCategory @ID");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteCategory @ID", new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public List<Category> SearchCategoryByName(string name)
        {
            List<Category> listCategory = new List<Category>();
            string query = $"select * from CategoryFood where dbo.fuConvertToUnsign1(Name) like N'%' + dbo.fuConvertToUnsign1(N'{name}') + '%'";

            DataTable table = new DataTable();
            try
            {
                table = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in table.Rows)
            {
                Category category = new Category(row);
                listCategory.Add(category);
            }
            return listCategory;
        }
    }
}