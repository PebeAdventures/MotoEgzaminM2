namespace MotoEgzaminM2.Data.Entities
{
    public class EduMaterialReview
    {
        public int Id { get; set; }
        public string ReviewText { get; set; }
        public int ReviewScore { get; set; }

        public EduMaterial EduMaterial { get; set; }
    }
}
