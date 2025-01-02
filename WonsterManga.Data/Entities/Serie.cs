using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WonsterManga.Data.Entities;
using WonsterManga.Domain.Entities;

namespace WonsterManga.Domain.Entities
{
    public class Serie
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [Display(Name = "Titulo")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Descripción")]
        [StringLength(2000)]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public SerieState SerieState { get; set; }
        [Required]
        [Display(Name = "Fecha lanzamiento")]
        public DateOnly StartDate { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Imagen portada")]
        public string ProfilePictureUrl { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Imagen banner")]
        public string BannerPictureUrl { get; set; }
        [Display(Name = "Capitulos")]
        public IEnumerable<Chapter?> Chapters { get; set; }
        public int Quantity { get; set; }
        [Display(Name = "Usuario")]
        public IEnumerable<User?> Followers { get; set; }
        [Display(Name = "Segudores")]
        public int FollowersCount { get; set; }
        [Display(Name = "Última actualización")]
        public DateTime LastUpdate { get; set; }
        [MaybeNull]
        public IEnumerable<Volume?> Volumes { get; set; }
        [Required]
        public IEnumerable<CategorySerie?> Categories { get; set; }

    }
}
