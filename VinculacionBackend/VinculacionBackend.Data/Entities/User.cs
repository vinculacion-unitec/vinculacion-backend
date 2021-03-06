﻿using System;
using VinculacionBackend.Data.Enums;

namespace VinculacionBackend.Data.Entities
{
    public class User
    {
        public long Id { get; set;  }
        public string AccountId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Major Major { get; set; }
        public string Campus { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool Finiquiteado { get; set; }
        public Status Status { get; set; }

    }
}