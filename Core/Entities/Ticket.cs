using System;

namespace Core.Entities
{
    public class Ticket : BaseEntity
    {
        public bool Status { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Price { get; set; }
        public Seat Seat { get; set; }
        public int SeatId { get; set; }
        public Show Show { get; set; }
        public int? ShowId {get; set;}      

    }
}