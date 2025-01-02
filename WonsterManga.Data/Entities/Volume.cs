using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonsterManga.Domain.Entities
{
    public class Volume
    {
        public Volume() { }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Número")]
        public int Number { get; set; }
        [Required]
        [Display(Name = "Fecha de lanzamiento")]
        public DateOnly Release {  get; set; }
        public IEnumerable<Chapter> Chapters { get; set; }
    }
}
