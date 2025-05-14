using OriseProfile.Domain.Models;
using MediatR;
using OriseProfile.Application.DTOs;
using System.Collections.Generic;

namespace OriseProfile.Application.Commands
{
    public class SubmitPersonCommand : IRequest<PersonResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> SocialSkills { get; set; }
        public List<SocialAccount> SocialAccounts { get; set; }
    }
}