using MotoEgzaminM2.Data;
using MotoEgzaminM2.DTO.EduMaterialReview;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services
{
    public class EduMaterialReviewService : IEduMaterialReviewService
    {

        private readonly IUnitOfWork _unitOfWork;

        public EduMaterialReviewService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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

        public Task<IEnumerable<EduMaterialReviewReadDTO>> GetAllReviews()
        {
            /* var reviews = await _unitOfWork.EduMaterialsReview.GetAllReviewsAsync();
             var reviewDTO = _mapper.Map<IEnumerable<EduMaterialReview>, IEnumerable<EduMaterialReadDTO>>(reviews.ToList());
             return reviewDTO;*/

            return null;
        }
    }
}
