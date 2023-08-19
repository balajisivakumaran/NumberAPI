using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NumberAPI.Models
{
    public class NumItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int NumberItem { get; set; }
    }
}