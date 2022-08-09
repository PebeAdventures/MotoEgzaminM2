using MotoEgzaminM2.Data.Context;
using MotoEgzaminM2.Data.DAL.Interfaces;
using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Data.DAL.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly MotoEgzaminM2Context _context;
    public UserRepository(MotoEgzaminM2Context context) : base(context)
    {
        _context = context;
    }

    public async void save(User user)
    {
        await _context.AddAsync(user);
    }
}