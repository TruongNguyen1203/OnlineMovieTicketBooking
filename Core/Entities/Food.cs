namespace Core.Entities
{
    public class Food : BaseEntity
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public string PictureUrl {get; set;}
        public decimal Price { get; set; }
    }
}