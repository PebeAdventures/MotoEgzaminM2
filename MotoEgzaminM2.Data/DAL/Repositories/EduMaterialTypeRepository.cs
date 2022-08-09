using Microsoft.EntityFrameworkCore;
using MotoEgzaminM2.Data.Context;
using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Data.DAL.Repositories
{
    public class EduMaterialTypeRepository : BaseRepository<EduMaterialType>, IEduMaterialTypeRepository
    {
        private readonly MotoEgzaminM2Context _context;
        public EduMaterialTypeRepository(MotoEgzaminM2Context context) : base(context)
        {
            _context = context;
        }
        public Task<List<EduMaterialType>> GetAllTypesAsync()
        {
            return _context.EduMaterialType.ToListAsync();
        }
    }
}
