using CleanArcMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Aplication.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This Name is required")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "This Description is required")]
        [MinLength(5)]
        [MaxLength(200)]
        public string Description { get;  set; }

        //[Required(ErrorMessage ="The Price is required")]
        //[Column(TypeName = "decimal (18, 2")]
        //[DisplayFormat(DataFormatString = "{0:C2")]
        //[DataType(DataType.Currency)]
        //[DisplayName("Price")]
        public decimal Price { get;  set; }

        [Required(ErrorMessage = "This Stock is required")]
        [Range(1, 9999)]
        [DisplayName("Stock")]
        public int Stock { get;  set; }

        [MaxLength(250)]
        [DisplayName("Product Image")]
        public string Image { get;  set; }
        public int CategoryId { get;  set; }

        [DisplayName("Category")]
        public Category Category { get;  set; }
    }
}
