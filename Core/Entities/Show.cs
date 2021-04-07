using System;
using Core.Entities;

namespace Core.Entities
{
    public class Show : BaseEntity
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public DateTime TimeStart { get; set; }
        public string  Language { get; set; }
        public int ScreenId { get; set; }
        public Screen Screen { get; set; }
    }
}