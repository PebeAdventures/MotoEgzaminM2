namespace MotoEgzaminM2.Data.Entities
{
    public class EduMaterial
    {
        public int EduMaterialId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public EduMaterialType Type { get; set; }
        public IEnumerable<EduMaterialReview> eduMaterialReviews { get; set; }
        public Author Author { get; set; }
        public string DateOfPublish { get; set; }

    }
}
