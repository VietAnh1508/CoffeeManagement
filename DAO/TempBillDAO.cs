using System;
using System.Collections.Generic;
using System.Data;

using DTO;

namespace DAO
{
    public class TempBillDAO
    {
        private static TempBillDAO instance;
        public static TempBillDAO Instance
        {
            get => instance = instance ?? new TempBillDAO();
        }

        private TempBillDAO() { }

        public DataTable GetListTempBillByTableID(int tableID)
        {

            string query = "USP_GetListTempBillByTableID @TableID";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { tableID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}