﻿namespace VolunteeringApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}