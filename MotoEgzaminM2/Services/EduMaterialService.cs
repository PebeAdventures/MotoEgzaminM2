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
            var materials = await _unitOfWork.EduMaterials.GetAllMaterialsAsync();
            var materialsDTO = _mapper.Map<IEnumerable<EduMaterial>, IEnumerable<EduMaterialReadDTO>>(materials.ToList());
            return materialsDTO;
        }

        public async Task<IEnumerable<EduMaterialWithRatedAuthorReadDTO>> GetAllMaterialsFromAuthorWithScoreAbove5(int authorId)
        {
            var author = await _unitOfWork.Author.FindById(authorId);
            if (author.Count() == 0)
            {
                throw new Exception(authorId + " not exists");
            }
            var materials = await _unitOfWork.EduMaterials.FindAllWithRankGreaterThan5(authorId);
            List<EduMaterial> source = materials.ToList().Where(x =>
                        {
                            var reviews = x.eduMaterialReviews;
                            var scoreSum = reviews.Select(x => x.ReviewScore).Sum();
                            var amountOfReviews = Math.Max(1, reviews.Count());
                            return (scoreSum / amountOfReviews) > 5;
                        }).ToList();
            return _mapper.Map<List<EduMaterial>, List<EduMaterialWithRatedAuthorReadDTO>>(source);
        }

        public async Task<IEnumerable<EduMaterialReadDTO>> GetAllMaterialsFromType(int typeId)
        {
            var materials = await _unitOfWork.EduMaterials.GetAllMaterialsAsync();
            var materialsForSelectedType = materials.Where(x => x.Type.TypeId == typeId).ToList();
            var materialsDTO = _mapper.Map<IEnumerable<EduMaterial>, IEnumerable<EduMaterialReadDTO>>(materialsForSelectedType.ToList());
            return materialsDTO;
        }
    }
}
