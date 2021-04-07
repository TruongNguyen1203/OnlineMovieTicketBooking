namespace Core.Entities
{
    public class Member : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public int VND { get; set; }

    }
}