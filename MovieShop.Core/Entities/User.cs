﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Core.Entities
{
   public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public string PhoneNumber { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public DateTime? LockOutEndDate { get; set; }
        public DateTime? LastLoginDateTime { get; set; }
        public bool IsLocked { get; set; }
        public int? AccessFailedCount { get; set; }

        public ICollection<Role> Role { get; set; }
        public ICollection<Purchase> Purchases { get; set; }

    }
}
