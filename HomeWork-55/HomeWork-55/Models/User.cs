using System;
using Microsoft.AspNetCore.Identity;

namespace HomeWork_55.Models
{
    public class User : IdentityUser
    {
        public DateTime DateOfBirth { get; set; }
    }
}