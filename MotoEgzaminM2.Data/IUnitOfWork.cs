using MotoEgzaminM2.Data.DAL.Interfaces;
using MotoEgzaminM2.Data.DAL.Repositories;

namespace MotoEgzaminM2.Data
{
    public interface IUnitOfWork
    {
        IEduMaterialRepository EduMaterials { get; }
        IEduMaterialReviewRepository EduMaterialsReview { get; }
        IEduMaterialTypeRepository EduMaterialsType { get; }
        IAuthorRepository Author { get; }
    }
}