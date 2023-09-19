using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TECHNO_MVC.Models
{
    public class Category
    {
        [key]
        public int id { get; set; }
        [Required]
        public String Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage = "Display order must be between 1 and 100 only!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDatetime { get; set; }= DateTime.UtcNow;

    }
}
