using System.ComponentModel.DataAnnotations;

namespace MotoEgzaminM2.DTO.Admin
{
    public class AdminCreateDTO
    {
        [Required]
        [MaxLengthAttribute(10)]
        public string Username { get; set; }
        [Required]
        [MaxLengthAttribute(30)]
        public string Password { get; set; }

    }
}