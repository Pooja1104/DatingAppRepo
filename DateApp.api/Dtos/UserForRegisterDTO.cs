
using System.ComponentModel.DataAnnotations;
namespace DateApp.api.Dtos
{
    
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
       [StringLength(8,MinimumLength=4,ErrorMessage="You must specify password between 4-8")]
        public string Password { get; set; }
    }
}