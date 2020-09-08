using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GitTaskEx.Models
{[Table("Emp")]
    public class Emp
    {[Key]
        public int EId { get; set; }
        [Required]
        public string EName { get; set; }
        [Required]
        public string EDesig { get; set; }
        [Required]
        public DateTime EDoj { get; set; }
    }
}