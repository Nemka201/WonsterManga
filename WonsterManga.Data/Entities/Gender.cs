using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonsterManga.Domain.Entities
{
    public class Gender
    {
        [Key]
        public short Id { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Genero")]
        public string Name { get; set; }
    }
}
