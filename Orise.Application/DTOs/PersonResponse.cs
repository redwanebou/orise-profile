using OriseProfile.Domain.Models;

namespace OriseProfile.Application.DTOs
{
    public class PersonResponse
    {
        public int VowelCount { get; set; }
        public int ConsonantCount { get; set; }
        public string ReversedName { get; set; }
        public Person Person { get; set; }
    }
}