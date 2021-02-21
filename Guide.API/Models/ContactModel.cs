using System.ComponentModel.DataAnnotations;

namespace Guide.API.Models
{
    public class ContactModel
    {
        [Required]
        public int ContactType { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(1000)]
        public string ContactContent { get; set; }
        [Required]
        public string PersonId { get; set; }
    }
}
