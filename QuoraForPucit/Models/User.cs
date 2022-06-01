using System;
using System.Collections.Generic;

namespace QuoraForPucit.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
