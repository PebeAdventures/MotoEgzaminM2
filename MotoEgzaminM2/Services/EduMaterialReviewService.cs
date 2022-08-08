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

        public Task CreateReview(EduMaterialReviewCreateDTO reviewCreateDTO)
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
            var reviewList = new List<EduMaterialReviewReadDTO>();

            return null;
        }
    }
}
