using System.Data;

namespace DTO
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Category() { }

        public Category(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Category(DataRow row)
        {
            ID = (int)row["ID"];
            Name = row["Name"].ToString();
        }
    }
}