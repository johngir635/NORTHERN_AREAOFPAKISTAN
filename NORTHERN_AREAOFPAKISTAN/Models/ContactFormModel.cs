using System.ComponentModel.DataAnnotations;

namespace NORTHERN_AREAOFPAKISTAN.Models
{
    public class ContactFormModel
    {

        [Key]
             public int Id { get; set; }
            [Required]
            [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
            public string Name { get; set; }

            [Required]
            [EmailAddress(ErrorMessage = "Invalid Email Address")]
            public string Email { get; set; }

            [Required]
            public string Country { get; set; }

            [Required]
            [StringLength(1000, ErrorMessage = "Remarks cannot be longer than 1000 characters.")]
            public string Remarks { get; set; }
        
    }
}
