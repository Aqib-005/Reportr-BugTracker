﻿using Microsoft.AspNetCore.Identity;

namespace BugTracker.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 

    }
}
