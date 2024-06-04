
using System.ComponentModel.DataAnnotations;

namespace OnLIneSHOP.Models.Base
{
    public class User : BaseClass
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Password { get; set; }  
        public List<Review> Reviews { get; set; }
    

    }
}
