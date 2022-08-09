using AutoMapper;
using MotoEgzaminM2.Data;
using MotoEgzaminM2.Data.Entities;
using MotoEgzaminM2.DTO.EduMaterialType;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services
{
    public class EduMaterialTypeService : IEduMaterialTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EduMaterialTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<EduMaterialTypeDTO>> findAll()
        {
            return await GetAll();
        }

        public async Task<List<EduMaterialTypeDTO>> findByName(string name)
        {
            var result = await GetAll();
            var byName = result.Where(x => x.Name == name);
            return byName.ToList();
        }

        private async Task<List<EduMaterialTypeDTO>> GetAll()
        {
            var result = await _unitOfWork.EduMaterialsType.GetAllTypesAsync();
            return _mapper.Map<List<EduMaterialType>, List<EduMaterialTypeDTO>>(result.ToList());
        }
    }
}
