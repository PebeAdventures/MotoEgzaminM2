

using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Factories.Authors
{
    public class AuthorFactory
    {
        public Author Create(AuthorFactoryRequest request)
        {
            var author = CreateAuthorFrom(request);
            return author;
        }

        private Author CreateAuthorFrom(AuthorFactoryRequest request)
        {
            var author = new Author();
            author.AuthorName = request.AuthorName;
            author.Description = request.Description;
            author.NumberOfMaterials = request.NumberOfMaterials;
            author.Materials = request.eduMaterials;
            return author;
        }
    }
}
