namespace MotoEgzaminM2.DTO.Author
{
    public class AuthorReadDTO
    {
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public int NumberOfMaterials { get; set; }
        public IEnumerable<string> Materials { get; set; }

    }
}
