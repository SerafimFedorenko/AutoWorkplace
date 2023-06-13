using System.ComponentModel.DataAnnotations;

namespace AutoWorkplaceLib.Models.Base
{
    public abstract class BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
