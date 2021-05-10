using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.DAL.Models
{
    public partial class TblHousingUnitRelevant
    {
        public int HousingUnitId { get; set; }
        public string CustomersId { get; set; }

        public virtual TblCustomer Customers { get; set; }
        public virtual TblHousingUnit HousingUnit { get; set; }
    }
}
