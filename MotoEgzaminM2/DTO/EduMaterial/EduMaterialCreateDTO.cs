using System.ComponentModel.DataAnnotations;

namespace MotoEgzaminM2.DTO.EduMaterial
{
    public class EduMaterialCreateDTO
    {
        public int MaterialId { get; set; }

        [Required]
        [MaxLengthAttribute(30)]
        public string Title { get; set; }
        [Required]
        [MaxLengthAttribute(250)]
        public string Description { get; set; }
        [Required]
        [MaxLengthAttribute(250)]
        public string Location { get; set; }
        [Required]
        [MaxLengthAttribute(5)]
        public int AuthorId { get; set; }
        [Required]
        [MaxLengthAttribute(50)]
        public int TypeId { get; set; }

        [Required]
        public string DateOfPublish { get; set; }
    }
}

