using System;
using System.Data;

namespace DAO
{
    public class AccountTypeDAO
    {
        private static AccountTypeDAO instance;
        public static AccountTypeDAO Instance
        {
            get => instance = instance ?? new AccountTypeDAO();
        }
        private AccountTypeDAO() { }

        public DataTable GetAllAccountType()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("select * from AccountType");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}