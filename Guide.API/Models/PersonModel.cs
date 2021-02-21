using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guide.API.Models
{
    public class PersonModel
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Company { get; set; }
    }
}
