
using System.ComponentModel.DataAnnotations;

namespace crudApiApp.Models
{
    public class PersonModel
    {
        public long Id {get; set;}
        [Required]
        [MaxLength(50)]
        public string? Name {get; set;}
        [Required]
        [MaxLength(10)]
        public string? Contact {get;set;}
        [Required]
        [EmailAddress]
        [MaxLength(20)]
        public string? Email {get; set;}
    }
}