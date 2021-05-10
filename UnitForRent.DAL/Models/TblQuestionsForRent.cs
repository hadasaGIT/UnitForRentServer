using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.DAL.Models
{
    public partial class TblQuestionsForRent
    {
        public TblQuestionsForRent()
        {
            TblAnswersForRents = new HashSet<TblAnswersForRent>();
        }

        public int QuestionsId { get; set; }
        public string CustomersId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int HousingUnitId { get; set; }

        public virtual TblCustomer Customers { get; set; }
        public virtual TblHousingUnit HousingUnit { get; set; }
        public virtual ICollection<TblAnswersForRent> TblAnswersForRents { get; set; }
    }
}
