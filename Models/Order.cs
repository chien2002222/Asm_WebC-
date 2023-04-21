using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Order
    {
        public int Id { get; set; }
        [MinLength(3, ErrorMessage = "Customer name must have at least 3 character")]
        [MaxLength(20, ErrorMessage = "Customers name have a maximum of 20 characters")]
        public string Customer{ get; set; }
        [Required (ErrorMessage ="Order date cannot be empty")]
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage = "Order quantity cannot be empty")]
        public int OrderQuantity { get; set; }
        [Required(ErrorMessage = "Order price cannot be empty")]
        [Range(1,1000, ErrorMessage ="Order price must be between 1 to 1000")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Order price cannot be empty")]
        [Range(1, 1000, ErrorMessage = "Order price must be between 1 to 1000")]
        public double OrderPrice { get; set; }
        [MinLength(3, ErrorMessage = "Order name must have at least 3 character")]
        [MaxLength(20, ErrorMessage = "Order name have a maximum of 20 characters")]
        public string OrderName { get; set; }
        [Required (ErrorMessage ="Status cannot be empty")]
        public int Status { get; set; }


        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
