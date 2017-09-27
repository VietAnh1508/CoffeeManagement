using System.Data;

namespace DTO
{
    public class TempBill
    {
        public string Food { get; set; }
        public int AmountFood { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }

        public TempBill(string foodName, int amount, int price, int totalPrice = 0)
        {
            Food = foodName;
            AmountFood = amount;
            Price = price;
            Total = totalPrice;
        }

        public TempBill(DataRow row)
        {
            Food = row["Name"].ToString();
            AmountFood = (int)row["Amount"];
            Price = (int)row["Price"];
            Total = (int)row["TotalPrice"];
        }
    }
}