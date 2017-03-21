using System.ComponentModel.DataAnnotations;

namespace TestProject.DataAccessLayer.Entities
{
    public class Pet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; }
    }
}
