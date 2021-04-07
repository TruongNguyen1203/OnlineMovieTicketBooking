using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Bill : BaseEntity
    {
        public DateTime DateTime { get; set; }
        public int Points { get; set; }
        public decimal TotalPrice { get; set; }
        public FoodBill FoodBill { get; set; }
        public int FoodBillId { get; set; }
        public Discount Discount { get; set; }
        public int DiscountId { get; set; }
        public List<Ticket> TicketItems { get; set; } = new List<Ticket>();


    }
}