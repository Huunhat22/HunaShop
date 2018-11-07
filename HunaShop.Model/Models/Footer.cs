using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HunaShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public String ID { get; set; }

        [Required]
        public String Content { get; set; }
    }
}