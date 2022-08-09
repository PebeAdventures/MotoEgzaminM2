namespace MotoEgzaminM2.Data.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }

        public int NumberOfMaterials { get; set; }

        public IEnumerable<EduMaterial> Materials { get; set; }
    }
}
