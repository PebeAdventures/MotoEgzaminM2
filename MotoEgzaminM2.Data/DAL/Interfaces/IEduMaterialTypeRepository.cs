using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Data.DAL.Repositories
{
    public interface IEduMaterialTypeRepository
    {
        Task<List<EduMaterialType>> GetAllTypesAsync();

    }
}