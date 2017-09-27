using System.Data;

namespace DTO
{
    public class Account
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public int TypeID { get; set; }

        public Account(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public Account(string userName, string displayName, int typeID, string password = null)
        {
            UserName = userName;
            DisplayName = displayName;
            TypeID = typeID;
            Password = password;
        }

        public Account(DataRow row)
        {
            UserName = row["UserName"].ToString();
            DisplayName = row["DisplayName"].ToString();
            TypeID = (int)row["TypeID"];
            Password = row["Password"].ToString();
        }
    }
}