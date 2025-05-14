using OriseProfile.Domain.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OriseProfile.Application.DTOs
{
    public class PersonRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public List<string> SocialSkills { get; set; } = new();
        public List<SocialAccount> SocialAccounts { get; set; } = new();
    }
}