namespace Core.Entities
{
    public class Screen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TheaterId { get; set; }
        public Theater Theater { get; set; } 
    }
}