using System.ComponentModel.DataAnnotations;

namespace MotoEgzaminM2.DTO.EduMaterialReview
{
    public class EduMaterialReviewCreateDTO
    {

        public int ReviewId { get; set; }

        [MaxLengthAttribute(50)]
        public int? ReviewReferenceId { get; set; }

        [Required]
        [MaxLengthAttribute(250)]
        public string ReviewText { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Score must be between 1 to 10")]
        public int ReviewScore { get; set; }
    }
}

