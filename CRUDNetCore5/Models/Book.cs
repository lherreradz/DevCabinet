using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDNetCore5.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title mandatory")]
        [StringLength(50, ErrorMessage = "The {0} should have at least {2} characters and maximum {1}", MinimumLength = 3)]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description mandatory")]
        [StringLength(50, ErrorMessage = "The {0} should have at least {2} characters and maximum {1}", MinimumLength = 3)]
        [Display(Name = "Book Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Publication Date mandatory")]
        [DataType(DataType.Date)]
        [Display(Name = "Publication Date")]
        public DateTime PublicationDate { get; set; }

        [Required(ErrorMessage = "Author mandatory")]
        [StringLength(50, ErrorMessage = "The {0} should have at least {2} characters and maximum {1}", MinimumLength = 3)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price mandatory")]
        public int Price { get; set; }
    }
}
