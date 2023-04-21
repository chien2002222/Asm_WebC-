using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Name length must be more than 3 characters"), MaxLength(20, ErrorMessage = "Name length must be less than 20 characters ")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
