using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.Models
{
    public partial class TblManager
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phon1 { get; set; }
        public string Phon2 { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
