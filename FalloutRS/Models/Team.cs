using System.ComponentModel.DataAnnotations;

namespace FalloutRS.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Character> Characters { get; set; }

        // Additional properties and validation 

    }
}
