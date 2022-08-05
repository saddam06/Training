using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Training.Web.Models
{
    [Table(name: "UserResponds")]
    public class UserResponds
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        [Required]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]

        public string UserFirstName { get; set; }

        [Required]
        [StringLength(100)]

        public string UserLastName { get; set; }

        [Required]
        [StringLength(300)]

        public string UserMessage { get; set; }







    }

}