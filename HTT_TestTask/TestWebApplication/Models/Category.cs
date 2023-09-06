using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApplication.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
		public int CategoryId { get; set; }

        [Column]
		[StringLength(255)]
		public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
