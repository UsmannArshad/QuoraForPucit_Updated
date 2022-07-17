using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuoraForPucit.Models
{
    public partial class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Your Name"), StringLength(30, ErrorMessage = "Name cannot exceeds thirty characters")]
        public string? Name { get; set; } = null!;
        [Range(15, 100, ErrorMessage = "Age must be in between 15 and 100"), Required]
        public int? Age { get; set; }
        [EmailAddress(ErrorMessage = "Provide a Valid Email"), Required(ErrorMessage = "Enter Username")]
        public string? Username { get; set; } = null!;
        [Required(ErrorMessage = "Enter Password")]
        public string? Password { get; set; } = null!;
    }
}
