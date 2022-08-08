using MotoEgzaminM2.Data.DAL.Interfaces;
using MotoEgzaminM2.Data.DAL.Repositories;

namespace MotoEgzaminM2.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IEduMaterialRepository eduMaterials, IEduMaterialReviewRepository eduMaterialsReview, IEduMaterialTypeRepository eduMaterialsType, IAuthorRepository author)
        {
            EduMaterials = eduMaterials;
            EduMaterialsReview = eduMaterialsReview;
            EduMaterialsType = eduMaterialsType;
            Author = author;
        }

        public IEduMaterialRepository EduMaterials { get; }

        public IEduMaterialReviewRepository EduMaterialsReview { get; }

        public IEduMaterialTypeRepository EduMaterialsType { get; }

        public IAuthorRepository Author { get; }
    }
}
