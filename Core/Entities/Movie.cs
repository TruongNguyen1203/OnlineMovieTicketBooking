using System;

namespace Core.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public int RunningTime { get; set; }
        public string Poster { get; set; }   
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Directors { get; set; }
        public string Actors { get; set; }
        public string Rules { get; set; }
        public string Description { get; set; }
        public string Trailer { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}