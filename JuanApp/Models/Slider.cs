using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JuanApp.Attributes;
using JuanApp.Models.Common;

namespace JuanApp.Models
{
    public class Slider : BaseEntity
    {
        [Required]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } 
        public string ButtonText { get; set; }
        public string ButtonUrl { get; set; }
        [NotMapped]
        [FileLength(2)]
        [FileTypes("image/jpeg", "image/png", "image/gif")]
        public IFormFile File { get; set; }
    }
}
