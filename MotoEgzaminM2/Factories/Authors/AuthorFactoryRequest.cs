using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Factories.Authors
{
    public class AuthorFactoryRequest
    {


        public AuthorFactoryRequest(string AuthorName, string Description, int NumberOfMaterials, IEnumerable<EduMaterial> eduMaterials)
        {
            this.AuthorName = AuthorName;
            this.Description = Description;
            this.NumberOfMaterials = NumberOfMaterials;
            this.eduMaterials = eduMaterials;
        }

        public string AuthorName { get; }
        public string Description { get; }
        public int NumberOfMaterials { get; }
        public IEnumerable<EduMaterial> eduMaterials { get; }
    }
}
