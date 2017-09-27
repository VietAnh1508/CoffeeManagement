using System;
using System.Data;

namespace DTO
{
    public class Bill
    {
        public int ID { get; set; }
        public DateTime CheckIn { get; set; }
        public int Status { get; set; }
        public int Discount { get; set; }

        public Bill(int id, DateTime checkIn, int status, int discount = 0)
        {
            ID = id;
            CheckIn = checkIn;
            Status = status;
            Discount = discount;
        }

        public Bill(DataRow row)
        {
            ID = (int)row["id"];
            CheckIn = (DateTime)row["checkIn"];
            Status = (int)row["status"];

            if (row["discount"].ToString() != "")
                this.Discount = (int)row["discount"];
        }
    }
}