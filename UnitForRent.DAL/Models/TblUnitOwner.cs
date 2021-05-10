using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.DAL.Models
{
    public partial class TblUnitOwner
    {
        public TblUnitOwner()
        {
            TblHousingUnits = new HashSet<TblHousingUnit>();
            TblSearches = new HashSet<TblSearch>();
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phon1 { get; set; }
        public string Phon2 { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<TblHousingUnit> TblHousingUnits { get; set; }
        public virtual ICollection<TblSearch> TblSearches { get; set; }
    }
}
