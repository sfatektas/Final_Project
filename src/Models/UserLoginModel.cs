using System.ComponentModel.DataAnnotations;

namespace MSS_NewsWeb.Models
{
    public class UserLoginModel
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
