using MotoEgzaminM2.Data.Context;
using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Data.DAL.Repositories
{


    public class EduMaterialRepository : BaseRepository<EduMaterial>, IEduMaterialRepository
    {
        private readonly MotoEgzaminM2Context _context;
        public EduMaterialRepository(MotoEgzaminM2Context context) : base(context)
        {
            _context = context;
        }
    }

}
