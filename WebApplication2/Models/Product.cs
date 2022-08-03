using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Training.Web.Models
{
    [Table(name: "Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]

        public string Title { get; set; }

        [Required]
        [DefaultValue(1)]

        public short NumberOfProducts { get; set; }

        [Required]
        [DefaultValue(false)]

        public bool IsEnabled { get; set; }

        #region Navigation Properties to the Category Model

        public int ProductCategoryId { get; set; }


        [ForeignKey(nameof(Product.ProductCategoryId))]
        public Category ProductCategory { get; set; }

        #endregion
    }
   
}