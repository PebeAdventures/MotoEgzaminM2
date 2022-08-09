using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Factories.Reviews
{
    public class ReviewFactoryRequest
    {
        public ReviewFactoryRequest(string ReviewText, int ReviewScore, EduMaterial eduMaterial)
        {
            this.ReviewText = ReviewText;
            this.ReviewScore = ReviewScore;
            EduMaterial = eduMaterial;
        }

        public string ReviewText { get; }
        public int ReviewScore { get; }
        public EduMaterial EduMaterial { get; }
    }
}
