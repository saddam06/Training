﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Training.Web.Models;

namespace Training.Web.Models
{
    [Table(name: "Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CategoryId { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]

        public string CategoryName { get; set; }

        #region Navigation Properties to the Product Model

        public ICollection<Product> Products { get; set; }


        #endregion
    }
   
}


