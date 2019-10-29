using System.ComponentModel.DataAnnotations;
using System;

namespace Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "You must fill this field")]
        [MinLength(4)]
        public string Login { get; set; }
        [Required(ErrorMessage = "You must fill this field")]
        [MinLength(8)]
        public string Password { get; set; }
        [Required(ErrorMessage = "You must fill this field")]
        public string Email { get; set; }
        [Required(ErrorMessage = "You must fill this field")]
        public string Phone { get; set; }
    }
}
