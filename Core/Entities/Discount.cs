using System;

namespace Core.Entities
{
    public class Discount : BaseEntity
    {
        public string Name { get; set; }
        public string Describe { get; set; }
        public string QuantityUseByUser { get; set; }
        public string Code { get; set; }
        public int Points { get; set; }
        public string PictureUrl { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal MaximumDiscount {get; set;}

        public decimal DiscountPercent {get; set;}

    }
}