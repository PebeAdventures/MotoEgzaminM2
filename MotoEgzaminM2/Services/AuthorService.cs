using AutoMapper;
using MotoEgzaminM2.Data;
using MotoEgzaminM2.Data.Entities;
using MotoEgzaminM2.DTO.Author;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public AuthorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AuthorReadDTO>> GetAllAuthors()
        {
            var authors = await _unitOfWork.Author.GetAllAuthorsAsync();
            var authorDTO = _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorReadDTO>>(authors.ToList());
            return authorDTO;

        }
    }
}
