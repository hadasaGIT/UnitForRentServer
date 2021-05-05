using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.Models
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblFeedbacks = new HashSet<TblFeedback>();
            TblHousingUnitRelevants = new HashSet<TblHousingUnitRelevant>();
            TblQuestionsForRents = new HashSet<TblQuestionsForRent>();
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
        public bool IsActive { get; set; }

        public virtual ICollection<TblFeedback> TblFeedbacks { get; set; }
        public virtual ICollection<TblHousingUnitRelevant> TblHousingUnitRelevants { get; set; }
        public virtual ICollection<TblQuestionsForRent> TblQuestionsForRents { get; set; }
        public virtual ICollection<TblSearch> TblSearches { get; set; }
    }
}
