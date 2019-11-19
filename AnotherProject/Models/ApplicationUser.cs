using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnotherProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Description { get; set; }
        public int UserPhoneNumber { get; set; }
    }
}
