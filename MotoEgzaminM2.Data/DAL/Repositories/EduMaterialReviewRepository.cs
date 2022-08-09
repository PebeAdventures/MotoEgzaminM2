using Microsoft.EntityFrameworkCore;
using MotoEgzaminM2.Data.Context;
using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Data.DAL.Repositories
{
    public class EduMaterialReviewRepository : BaseRepository<EduMaterialReview>, IEduMaterialReviewRepository
    {
        private readonly MotoEgzaminM2Context _context;
        public EduMaterialReviewRepository(MotoEgzaminM2Context context) : base(context)
        {
            _context = context;
        }

        public async Task<List<EduMaterialReview>> GetAllReviewsAsync()
       => await _context.EduMaterialReviews.Include(x => x.EduMaterial).ToListAsync();
    }
}
