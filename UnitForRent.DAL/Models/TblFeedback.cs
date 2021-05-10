using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.DAL.Models
{
    public partial class TblFeedback
    {
        public int Id { get; set; }
        public int HousingUnitId { get; set; }
        public string CustomersId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public virtual TblCustomer Customers { get; set; }
        public virtual TblHousingUnit HousingUnit { get; set; }
    }
}
