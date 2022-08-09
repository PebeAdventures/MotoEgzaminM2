using AutoMapper;
using MotoEgzaminM2.Data;
using MotoEgzaminM2.Data.Entities;
using MotoEgzaminM2.DTO.EduMaterial;
using MotoEgzaminM2.DTO.EduMaterialReview;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services
{
    public class EduMaterialReviewService : IEduMaterialReviewService
    {

        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public EduMaterialReviewService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task CreateReview(int id, EduMaterialReviewCreateDTO reviewCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReview(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditReview(int id, EduMaterialReviewUpdateDTO reviewUpdateDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EduMaterialReviewReadDTO>> GetAllReviews()
        {
            var reviews = await _unitOfWork.EduMaterialsReview.GetAllReviewsAsync();
            var reviewDTO = _mapper.Map<IEnumerable<EduMaterialReview>, IEnumerable<EduMaterialReadDTO>>(reviews.ToList());
            return (IEnumerable<EduMaterialReviewReadDTO>)reviewDTO;
        }

    }
}
