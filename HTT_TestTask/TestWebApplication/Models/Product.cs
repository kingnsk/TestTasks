using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApplication.Models
{
    [Table("Product") ]
    public class Product
    {
        [Key]
		public int ProductId { get; set; }

		[Column]
		[StringLength(250)]
		public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


		[ForeignKey(nameof(Category))] 
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
