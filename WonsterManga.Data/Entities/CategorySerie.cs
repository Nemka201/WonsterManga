using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WonsterManga.Domain.Entities
{
    public class CategorySerie
    {
        [Required]
        [ForeignKey("Serie")]
        public long SerieId { get; set; }
        public Serie? Serie { get; set; }
        [Required]
        [ForeignKey("Category")]
        public short CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
