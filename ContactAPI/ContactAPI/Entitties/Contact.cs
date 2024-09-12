using System.ComponentModel.DataAnnotations;

namespace ContactAPI.Entitties
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string MobileNumber { get; set; }

        [Phone]
        public string SecondaryMobileNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Photo { get; set; }
    }
}
