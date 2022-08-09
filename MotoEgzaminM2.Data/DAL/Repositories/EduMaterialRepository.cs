using Microsoft.EntityFrameworkCore;
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
        public async Task<List<EduMaterial>> FindAllWithRankGreaterThan5(int AuthorId)
        {


            return await _context.EduMaterials.Include(x => x.eduMaterialReviews)
                .Where(x => x.Author.AuthorId == AuthorId)

                .ToListAsync();
        }



    }

}


