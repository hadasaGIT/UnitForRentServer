using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.Models
{
    public partial class TblHousingUnitImage
    {
        public int HousingUnitId { get; set; }
        public string Images { get; set; }

        public virtual TblHousingUnit HousingUnit { get; set; }
    }
}
