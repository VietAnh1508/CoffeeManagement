using System.Data;

namespace DTO
{
    public class BillInfo
    {
        public int ID { get; set; }
        public int BillID { get; set; }
        public int FoodID { get; set; }
        public int Amount { get; set; }

        public BillInfo(int id, int billID, int foodID, int amount)
        {
            ID = id;
            BillID = billID;
            FoodID = foodID;
            Amount = amount;
        }

        public BillInfo(DataRow row)
        {
            ID = (int)row["id"];
            BillID = (int)row["billID"];
            FoodID = (int)row["foodID"];
            Amount = (int)row["amount"];
        }
    }
}