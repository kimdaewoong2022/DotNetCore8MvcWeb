using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore8MvcWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("카테고리명")]
        public string Name { get; set; }
        [DisplayName("순번")]
        public int DisplayOrder { get; set; }
    }
}
