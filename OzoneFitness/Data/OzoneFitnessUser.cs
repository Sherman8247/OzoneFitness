﻿using Microsoft.AspNetCore.Identity;
namespace OzoneFitness.Data
{
    // Add profile data for users by adding properties to the CarRentalManagementUser class
    public class OzoneFitnessUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}