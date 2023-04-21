using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Book title must be longer than 3 character")]
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Author name is not valid!!!")]
        public string Author { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Description is too long!!!")]
        public string Description { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100")]
        public int Quantity { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "Price must be between 1 to 1000")]
        public double Price { get; set; }

        [Required]
        [Range(1, 9999, ErrorMessage = "Category can not be blank")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
