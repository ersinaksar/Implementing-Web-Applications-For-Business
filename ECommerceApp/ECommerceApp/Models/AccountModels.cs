using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Email is required!")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Security question is required!")]
        [Display(Name = "Security question")]
        public string Question { get; set; }
        [Required(ErrorMessage = "Security answer is required!")]
        [Display(Name = "Security answer")]
        public string Answer { get; set; }
    }

    public class LogonModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Old password is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "New password is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match!")]
        public string ConfirmPassword { get; set; }
    }
}
