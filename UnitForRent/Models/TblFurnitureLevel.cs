using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.Models
{
    public partial class TblFurnitureLevel
    {
        public TblFurnitureLevel()
        {
            TblHousingUnits = new HashSet<TblHousingUnit>();
            TblSearches = new HashSet<TblSearch>();
        }

        public int Id { get; set; }
        public string Level { get; set; }

        public virtual ICollection<TblHousingUnit> TblHousingUnits { get; set; }
        public virtual ICollection<TblSearch> TblSearches { get; set; }
    }
}
