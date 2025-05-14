using System.Collections.Generic;

namespace OriseProfile.Domain.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> SocialSkills { get; set; } = new();
        public List<SocialAccount> SocialAccounts { get; set; } = new();
    }
}