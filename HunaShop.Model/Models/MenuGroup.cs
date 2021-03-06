﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HunaShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}