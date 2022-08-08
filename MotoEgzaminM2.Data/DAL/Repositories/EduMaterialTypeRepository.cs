using MotoEgzaminM2.Data.Context;
using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Data.DAL.Repositories
{
    public class EduMaterialTypeRepository : BaseRepository<EduMaterialType>, IEduMaterialType
    {
        public EduMaterialTypeRepository(MotoEgzaminM2Context context) : base(context)
        {

        }
    }
}
