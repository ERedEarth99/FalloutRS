using System.ComponentModel.DataAnnotations;

namespace FalloutRS.Models
{
    public class Character
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Range(1, 100)]
        public int Health { get; set; }

        [Range(1, 100)]
        public int Attack { get; set; }

        [Range(1, 100)]
        public int Defense { get; set; }

        [Range(1, 100)]
        public int Speed { get; set; }

        // Additional properties and validation

    }
}
