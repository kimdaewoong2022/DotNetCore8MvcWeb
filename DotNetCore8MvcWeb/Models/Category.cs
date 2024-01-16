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
        [MaxLength(30)]
        public string Name { get; set; }

        [DisplayName("순번")]
        [Range(1, 100, ErrorMessage = "순번은 1-100 범위 안의 숫자")]
        public int DisplayOrder { get; set; }
    }
}
