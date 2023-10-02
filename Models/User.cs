using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage ="Required")]
        public String UserName { get; set; }
        [Required(ErrorMessage ="Required")]
        [EmailAddress]
        public String Email { get; set; }
        [Required(ErrorMessage = "Required")]
        public String Password { get; set; }
    }
}
