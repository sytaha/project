﻿using System.ComponentModel.DataAnnotations;

namespace MyApp.Models

{

    public class LoginModel

    {

        [Required(ErrorMessage = "Email is required")]

        [EmailAddress(ErrorMessage = "Invalid Email Address")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]

        [DataType(DataType.Password)]

        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }

}

