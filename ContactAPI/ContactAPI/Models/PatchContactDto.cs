using System.ComponentModel.DataAnnotations;

namespace ContactAPI.Models
{
    public class PatchContactDto
    {

        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Mobile number must be exactly 10 digits.")]
        public string MobileNumber { get; set; }

        [StringLength(10, MinimumLength = 10, ErrorMessage = "Secondary mobile number must be exactly 10 digits.")]
        public string SecondaryMobileNumber { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        public string Name { get; set; }
        public string Photo { get; set; }
    }
}
