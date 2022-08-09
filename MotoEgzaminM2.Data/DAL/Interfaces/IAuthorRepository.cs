using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Data.DAL.Interfaces
{
    public interface IAuthorRepository
    {
        Task<List<Author>> GetAllAuthorsAsync();
    }
}