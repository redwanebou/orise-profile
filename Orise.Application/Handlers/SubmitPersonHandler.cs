using OriseProfile.Application.Commands;
using OriseProfile.Application.DTOs;
using OriseProfile.Application.Interfaces;
using OriseProfile.Domain.Models;
using MediatR;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;

namespace OriseProfile.Application.Handlers
{
    public class SubmitPersonHandler : IRequestHandler<SubmitPersonCommand, PersonResponse>
    {
        private readonly IPersonRepository _repository;

        public SubmitPersonHandler(IPersonRepository repository)
        {
            _repository = repository;
        }

        public async Task<PersonResponse> Handle(SubmitPersonCommand request, CancellationToken cancellationToken)
        {
            var person = new Person
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                SocialSkills = request.SocialSkills,
                SocialAccounts = request.SocialAccounts
            };

            var fullName = person.FirstName + person.LastName;
            var response = new PersonResponse
            {
                VowelCount = fullName.Count(c => "aeiouAEIOU".Contains(c)),
                ConsonantCount = fullName.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c)),
                ReversedName = $"{Reverse(person.LastName)} {Reverse(person.FirstName)}",
                Person = person
            };

            await _repository.SaveAsync(person);
            return response;
        }

        private string Reverse(string input) => new string(input.Reverse().ToArray());
    }
}