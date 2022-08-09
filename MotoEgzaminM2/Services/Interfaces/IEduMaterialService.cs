using MotoEgzaminM2.DTO.EduMaterial;

namespace MotoEgzaminM2.Services.Interfaces
{
    public interface IEduMaterialService
    {
        Task<IEnumerable<EduMaterialReadDTO>> GetAllmaterials();
        Task<IEnumerable<EduMaterialWithRatedAuthorReadDTO>> GetAllMaterialsFromAuthorWithScoreAbove5(int authorId);
        Task<IEnumerable<EduMaterialReadDTO>> GetAllMaterialsFromType(int typeId);
        Task DeleteMaterial(int id);
        Task CreateMaterial(EduMaterialCreateDTO createDTO);
        Task EditMaterial(int id, EduMaterialUpdateDTO materialUpdateDTO);
    }
}