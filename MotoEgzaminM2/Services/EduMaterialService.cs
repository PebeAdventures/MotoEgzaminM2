using AutoMapper;
using MotoEgzaminM2.Data;
using MotoEgzaminM2.Data.Entities;
using MotoEgzaminM2.DTO.EduMaterial;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services
{
    public class EduMaterialService : IEduMaterialService
    {
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public EduMaterialService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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

        public async Task<IEnumerable<EduMaterialReadDTO>> GetAllmaterials()
        {
            var reviews = await _unitOfWork.EduMaterialsReview.GetAllReviewsAsync();
            var reviewDTO = _mapper.Map<IEnumerable<EduMaterialReview>, IEnumerable<EduMaterialReadDTO>>(reviews.ToList());
            return reviewDTO;
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
