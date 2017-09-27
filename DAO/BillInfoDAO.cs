using System.Collections.Generic;
using System.Data;

using DTO;

namespace DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get => instance = instance ?? new BillInfoDAO();
        }

        private BillInfoDAO() { }

        public void InsertBillInfo(int billID, int foodID, int amount)
        {
            string query = "USP_InsertBillInfo @BillID , @FoodID , @Amount";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID, foodID, amount });
            }
            catch { }
        }

        public void DeleteBillInfoByBillID(int billID)
        {
            string query = string.Format("USP_DeleteBillInfoByBillID @BillID");
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { billID });
            }
            catch { }
        }
    }
}