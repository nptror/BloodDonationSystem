using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDS.Common.DTOs
{
    internal class UserDTO
    {
        public string phoneNumber { get; set; }
        public string Password { get; set; }
        public string fullName { get; set; }
        public DateTime? dayOfBirth { get; set; }

    }
}
