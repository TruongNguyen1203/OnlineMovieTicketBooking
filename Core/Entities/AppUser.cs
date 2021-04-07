using System;

using Microsoft.AspNetCore.Identity;
namespace Core.Entities
{    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public int Point { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string PictureUrl { get; set; }
        public Member Member { get; set; }
        public int MemberId { get; set; }
    }
}