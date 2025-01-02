using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using WonsterManga.Data.Entities;
using WonsterManga.Domain.Entities;

namespace WonsterManga.Domain.Entities
{
    public class Chapter
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Titulo")]
        public required string Title { get; set; }
        [Required]
        [Display(Name = "Capitulo")]
        public int Number {  get; set; }
        [Required]
        [Display(Name = "Usuario")]
        public required User User { get; set; }
        [Required]
        [Display(Name = "Serie")]
        public required Serie Serie { get; set; }
        [MaybeNull]
        public IEnumerable<ChapterPage> ChapterPages { get; set; }
    }
}
