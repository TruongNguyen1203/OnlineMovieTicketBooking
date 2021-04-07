namespace Core.Entities
{
    public class Seat : BaseEntity
    {
        public string Name { get; set; }
        public SeatType SeatType { get; set; }
        public int SeatTypeId { get; set; }
        public Theater Theater { get; set; }
        public int TheaterId { get; set; }
        public Screen Screen { get; set; }
        public int ScreenId { get; set; }

    }
}