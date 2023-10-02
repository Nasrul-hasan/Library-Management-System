using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Required")]
        public String BookName { get; set; }
        [Required(ErrorMessage = "Required")]
        public String AuthorName { get; set; }
        [Required(ErrorMessage = "Required")]
        public String ISBN { get; set; }
        [Required(ErrorMessage = "Required")]
        public int Quantity { get; set; }
    }
}
