using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class UserModel : BaseApiModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public string? Password { set; get; }
        [Required(ErrorMessage = "Username is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string? Phone { set; get; }
        public int? Role { get; set; }
        public string? RoleName { get; set; }
        public int? Sex { get; set; }
        public string? Token { get; set; }
        public string? FileUrlRecord { set; get; }
    }
}
