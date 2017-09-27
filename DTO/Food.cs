using System.Data;

namespace DTO
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int Price { get; set; }

        public Food(string name, int categoryID, int price)
        {
            Name = name;
            CategoryID = categoryID;
            Price = price;
        }

        public Food(int id, string name, int categoryID, int price)
        {
            ID = id;
            Name = name;
            CategoryID = categoryID;
            Price = price;
        }

        public Food(DataRow row)
        {
            ID = (int)row["ID"];
            Name = row["Name"].ToString();
            CategoryID = (int)row["CategoryID"];
            Price = (int)row["Price"];
        }
    }
}