namespace MotoEgzaminM2.Data.Entities
{
    public class EduMaterial
    {
        public int EduMaterialId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public EduMaterialType Type { get; set; }
        public List<EduMaterialReview> eduMaterialReviews { get; set; }
        public string DateOfPublish { get; set; }

    }
}
