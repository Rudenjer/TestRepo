using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestProject.DataAccessLayer.Entities
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
    }
}
