using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Web.Mvc.Data.Entity
{
    public class CategoryPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        [DisplayName("Post Adı")]
        [MinLength(3, ErrorMessage = "{0} en az {1} karakter olabilir!")]
        public Post Post { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
