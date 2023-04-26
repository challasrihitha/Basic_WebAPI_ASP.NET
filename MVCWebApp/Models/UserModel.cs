using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MVCWebApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Required.")]
       
        public string? username { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string? password { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Compare("password",ErrorMessage = "passwords not match")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Required.")]
        [EmailAddress( ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }
    }
}

