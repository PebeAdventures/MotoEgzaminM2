using MotoEgzaminM2.Data;
using MotoEgzaminM2.DTO.EduMaterial;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services
{
    public class EduMaterialService : IEduMaterialService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EduMaterialService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task CreateMaterial(EduMaterialCreateDTO createDTO)
        {

            throw new NotImplementedException();
        }

        public Task DeleteMaterial(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditMaterial(int id, EduMaterialUpdateDTO materialUpdateDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EduMaterialReadDTO>> GetAllmaterials()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EduMaterialReadDTO>> GetAllMaterialsFromAuthorWithScoreAbove5(int authorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EduMaterialReadDTO>> GetAllMaterialsFromType(int typeId)
        {
            throw new NotImplementedException();
        }
    }
}
