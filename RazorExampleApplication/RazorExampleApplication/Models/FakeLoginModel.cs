using System.ComponentModel.DataAnnotations;

namespace RazorExampleApplication.Models
{
    public class FakeLoginModel
    {
        [Required(ErrorMessage = "Prasom ivesti varda")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
