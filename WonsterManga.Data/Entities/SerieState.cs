using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonsterManga.Domain.Entities
{
    public class SerieState
    {
        public SerieState() { }
        [Key]
        public short Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        [StringLength(15)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
    }
}
