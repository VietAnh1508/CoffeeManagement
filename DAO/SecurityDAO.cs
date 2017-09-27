using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SecurityDAO
    {
        private static SecurityDAO instance;
        public static SecurityDAO Instance
        {
            get => instance = instance ?? new SecurityDAO();
        }

        private SecurityDAO() { }

        public void BackupData(string path)
        {
            string query = $"BACKUP DATABASE CoffeeManagement TO DISK='{path}'";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RestoreData(string path)
        {
            string query = $"USE master RESTORE DATABASE CoffeeManagement FROM DISK='{path}'";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}