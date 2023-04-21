using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Request
    {
       public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Request name must have at least 3 character")]
        [MaxLength(15, ErrorMessage = "Request  name have a maximum of 15 characters")]
        public string Name { get; set; }

        [MinLength(10, ErrorMessage = "Description of request must be at least 10 characters")]
        public string Description { get; set; }
    }
}
