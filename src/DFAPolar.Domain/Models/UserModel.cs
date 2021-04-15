using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DFAPolar.Domain.Models
{
    public class UserModel: EntityModel
    {
        public UserModel()
        {
            UserRole = "User";
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserEmail { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string PhoneOne { get; set; }

        public string PhoneTwo { get; set; }

        public string Country { get; set; }

        public bool OfAge { get; set; }

        public string UserRole { get; set; }
    }
}
