﻿namespace VinculacionBackend.Data.Entities
{
    public class UserRole
    {
        public long Id { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
 
    }
}