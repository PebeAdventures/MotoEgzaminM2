using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Factories.Reviews
{
    public class ReviewFactory
    {

        public EduMaterialReview Create(ReviewFactoryRequest request)
        {
            var review = CreateReviewFrom(request);
            return review;
        }

        private EduMaterialReview CreateReviewFrom(ReviewFactoryRequest request)
        {
            var review = new EduMaterialReview();
            review.ReviewText = request.ReviewText;
            review.ReviewScore = request.ReviewScore;
            review.EduMaterial = request.EduMaterial;
            return review;
        }
    }
}

