using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DFAPolar.API.Dtos
{
    public class UserResultDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserEmail { get; set; }

        public string Password { get; set; }

        public string PhoneOne { get; set; }

        public string PhoneTwo { get; set; }

        public string Country { get; set; }

        public bool OfAge { get; set; }

        public bool IsAdmin { get; set; }
    }
}
