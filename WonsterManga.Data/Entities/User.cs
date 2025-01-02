using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WonsterManga.Domain.Entities;

namespace WonsterManga.Data.Entities
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Nombre")]
        [MaxLength(20)]
        public required string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Contraseña")]
        [EmailAddress]
        public required string Email { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Contraseña")]
        [MaxLength(100)]
        public string? Password { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Usuario")]
        [MaxLength(100)]
        public required string Username { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Genero")]
        public Gender? Gender { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsLocked { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public  Role Role { get; set; }
        public IEnumerable<Chapter> ChaptersUploaded { get; set; }
        public int ChapterCount { get; set; }
        public IEnumerable<User>? Followers { get; set; }
        public int FollowersCount { get;set; }
        [NotMapped]
        public string? Token { get; set; }
    }
}
