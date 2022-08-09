using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Data.DAL.Repositories
{
    public interface IEduMaterialRepository
    {
        Task<List<EduMaterial>> FindAllWithRankGreaterThan5(int AuthorId);
    }
}