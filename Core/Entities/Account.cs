using System;

namespace Core.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
        public DateTime Birthday { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int TypesOfAccountId { get; set; }
        public TypesOfAccount TypesOfAccount { get; set; }
    }
}