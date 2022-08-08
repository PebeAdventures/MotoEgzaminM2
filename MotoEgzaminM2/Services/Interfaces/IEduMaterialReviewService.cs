using MotoEgzaminM2.DTO.EduMaterialReview;

namespace MotoEgzaminM2.Services.Interfaces
{
    public interface IEduMaterialReviewService
    {
        Task CreateReview(EduMaterialReviewCreateDTO reviewCreateDTO);
        Task DeleteReview(int id);
        Task EditReview(int id, EduMaterialReviewUpdateDTO reviewUpdateDTO);
        Task<IEnumerable<EduMaterialReviewReadDTO>> GetAllReviews();
    }
}