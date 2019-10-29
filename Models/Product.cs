using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required(ErrorMessage = "You must fill this field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must fill this field")]
        public double Price { get; set; }
        [Required(ErrorMessage = "You must fill this field")]
        public string Description { get; set; }
    }
}
