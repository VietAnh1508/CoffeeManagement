using System;
using System.Data;

using DAO;

namespace BUS
{
    public class AccountTypeBUS
    {
        private static AccountTypeBUS instance;
        public static AccountTypeBUS Instance
        {
            get => instance = instance ?? new AccountTypeBUS();
        }

        private AccountTypeBUS() { }

        public DataTable GetAllAccountType()
        {
            try
            {
                return AccountTypeDAO.Instance.GetAllAccountType();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}