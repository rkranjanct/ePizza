using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Domain.Models
{
    public class UserDomain
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }
    }
}
