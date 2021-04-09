namespace Core.Entities
{
    public class Member : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Points { get; set; }
        public decimal VND { get; set; }

    }
}