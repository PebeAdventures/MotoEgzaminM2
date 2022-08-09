using MotoEgzaminM2.DTO.EduMaterialType;

namespace MotoEgzaminM2.Services.Interfaces
{
    public interface IEduMaterialTypeService
    {
        public Task<List<EduMaterialTypeDTO>> findAll();

        public Task<List<EduMaterialTypeDTO>> findByName(string name);
    }
}