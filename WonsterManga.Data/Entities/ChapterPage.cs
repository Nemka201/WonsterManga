using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WonsterManga.Data.Entities;

namespace WonsterManga.Domain.Entities
{
    public class ChapterPage
    {
        [Key]
        public long Id { get; set; }
        public Chapter Chapter { get; set; }
        [Required]
        [Display(Name = "Página")]
        public int Page { get; set; }
        [Required]
        [Display(Name = "URL de página")]
        public string PageURL { get; set; }
    }
}
