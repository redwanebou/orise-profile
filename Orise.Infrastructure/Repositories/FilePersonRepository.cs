using OriseProfile.Application.Interfaces;
using OriseProfile.Domain.Models;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace OriseProfile.Infrastructure.Persistence
{
    public class FilePersonRepository : IPersonRepository
    {
        private readonly string _filePath = "person_data.txt";

        public async Task SaveAsync(Person person)
        {
            var json = JsonSerializer.Serialize(person);
            await File.AppendAllTextAsync(_filePath, json + Environment.NewLine);
        }
    }
}