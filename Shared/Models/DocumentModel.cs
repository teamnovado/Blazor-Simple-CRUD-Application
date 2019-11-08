using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SharedLibrary.Models
{
    public class DocumentModel : EntityModelBase
    {
        [Required]
        [StringLength(50, ErrorMessage = "Title can be max 50 characters")]
        public string Title { get; set; }

        [Required, MaxLength(256)]
        [StringLength(256, ErrorMessage = "Description can be max 256 characters")]
        public string Description { get; set; }
        public string File { get; set; }
    }
}
