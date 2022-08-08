using MotoEgzaminM2.DTO.Author;

namespace MotoEgzaminM2.Services.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorReadDTO>> GetAllReviews();
    }
}