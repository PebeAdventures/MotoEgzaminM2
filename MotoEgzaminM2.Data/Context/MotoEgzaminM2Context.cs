using Microsoft.EntityFrameworkCore;
using MotoEgzaminM2.Data.Entities;

namespace MotoEgzaminM2.Data.Context
{
    public class MotoEgzaminM2Context : DbContext
    {
        public DbSet<EduMaterial> EduMaterials { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<EduMaterialReview> EduMaterialReviews { get; set; }
        public DbSet<EduMaterialType> EduMaterialType { get; set; }

        public MotoEgzaminM2Context(DbContextOptions<MotoEgzaminM2Context> options) : base(options)
        { }
    }
}
