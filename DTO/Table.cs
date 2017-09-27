using System.Data;

namespace DTO
{
    public class Table
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public Table(int id, string name, string status)
        {
            ID = id;
            Name = name;
            Status = status;
        }

        public Table(DataRow row)
        {
            ID = (int)row["ID"];
            Name = row["Name"].ToString();
            Status = row["Status"].ToString();
        }
    }
}