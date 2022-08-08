using MotoEgzaminM2.Data;
using MotoEgzaminM2.DTO.Author;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<AuthorReadDTO>> GetAllAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
