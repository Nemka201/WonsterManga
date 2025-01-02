using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WonsterManga.Domain.Entities;

namespace WonsterManga.Domain.Entities
{
    public class Category
    {
        [Key]
        public short Id { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name ="Nombre")]
        public string Name { get; set; }
        [Required]
        [StringLength(300)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Imagen Background")]
        public string BackgroundURL { get; set; }
        [MaybeNull]
        public IEnumerable<CategorySerie?> Series { get; set; }
    }
}
