namespace Core.Entities
{
    public class Food : BaseEntity
    {
        public string Name { get; set; }
        public string Desciption { get; set; }
        public string PictureUrl {get; set;}
        public decimal Price { get; set; }
    }
}