using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş bırakılamaz.")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden uzun olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden kısa olamaz.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden uzun olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden kısa olamaz.")]
        public string Description { get; set; }
        [DisplayName("Kategori Notu")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden uzun olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden kısa olamaz.")]
        public string Note { get; set; }
        [DisplayName("Kategori Aktifliği")]
        [Required(ErrorMessage = "{0} boş bırakılamaz.")]
        public bool IsActive { get; set; }
        [DisplayName("Kategori Varlığı")]
        [Required(ErrorMessage = "{0} boş bırakılamaz.")]
        public bool IsDeleted { get; set; }

    }
}
