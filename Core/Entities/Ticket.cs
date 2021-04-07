namespace Core.Entities
{
    public class Ticket : BaseEntity
    {
        public bool Status { get; set; }
        public Seat Seat { get; set; }
        public int SeatId { get; set; }
        public Show Show { get; set; }
        public int ShowId {get; set;}

    }
}