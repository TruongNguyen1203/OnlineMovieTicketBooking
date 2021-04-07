using System.Collections.Generic;

namespace Core.Entities
{
    public class FoodBill
    {   
        public string Id { get; set; }
        public List<Food> FoodItems { get; set; } = new List<Food>();
        public decimal TotalPrice { get; set; }
    }
}