using System.ComponentModel.DataAnnotations;

namespace RazorExampleApplication.Models
{
    public class IndexModel
    {
        [Required]
        public string Name { get; set; }

        public string Profession { get; set; }
    }
}
