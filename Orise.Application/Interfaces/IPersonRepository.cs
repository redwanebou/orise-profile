using OriseProfile.Domain.Models;
using System.Threading.Tasks;

namespace OriseProfile.Application.Interfaces
{
    public interface IPersonRepository
    {
        Task SaveAsync(Person person);
    }
}