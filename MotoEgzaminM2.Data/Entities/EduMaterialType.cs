using System.ComponentModel.DataAnnotations;

namespace MotoEgzaminM2.Data.Entities
{
    public class EduMaterialType
    {
        [Key]
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }

    }
}
