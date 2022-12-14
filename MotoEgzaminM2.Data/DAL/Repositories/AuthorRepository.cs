using Microsoft.EntityFrameworkCore;
using MotoEgzaminM2.Data.Context;
using MotoEgzaminM2.Data.DAL.Interfaces;
using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Data.DAL.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        private readonly MotoEgzaminM2Context _context;
        public AuthorRepository(MotoEgzaminM2Context context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Author>> GetAllAuthorsAsync()
        => await _context.Authors.Include(x => x.Materials).ToListAsync();

        public async Task<List<Author>> FindById(int AuthorId)
    => await _context.Authors.Where(x => x.AuthorId == AuthorId).ToListAsync();

    }
}
