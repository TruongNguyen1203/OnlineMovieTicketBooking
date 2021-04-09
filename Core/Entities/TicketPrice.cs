using System;

namespace Core.Entities
{
    public class TicketPrice : BaseEntity
    {
        public decimal Price { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public SeatType SeatType { get; set; }
        public int SeatTypeId { get; set; }
    }
}