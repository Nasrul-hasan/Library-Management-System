using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Borrow
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Required")]
        public String StudentName { get; set; }
        [Required(ErrorMessage = "Required")]
        public String Semester { get; set; }
        [Required(ErrorMessage = "Required")]
        public String Program { get; set; }
        [Required(ErrorMessage = "Required")]
        [MinLength(11,ErrorMessage ="Phone no should be 11 digit")]
        public String Phone { get; set; }
        [Required(ErrorMessage = "Required")]
        public String BookIssued { get; set; }
        [Required(ErrorMessage = "Required")]
        public int BookId { get; set; }
        [Required(ErrorMessage = "Required")]
        public DateTime IssuedDate { get; set; }
    }
}
