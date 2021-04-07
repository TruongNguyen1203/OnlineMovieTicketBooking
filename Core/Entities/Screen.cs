namespace Core.Entities
{
    public class Screen : BaseEntity
    {
        public string Name { get; set; }
        public Theater Theater { get; set; } 
        public int TheaterId { get; set; }
    }
}