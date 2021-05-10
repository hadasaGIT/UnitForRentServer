using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.DAL.Models
{
    public partial class TblHousingUnit
    {
        public TblHousingUnit()
        {
            TblFeedbacks = new HashSet<TblFeedback>();
            TblHousingUnitRelevants = new HashSet<TblHousingUnitRelevant>();
            TblQuestionsForRents = new HashSet<TblQuestionsForRent>();
        }

        public int Id { get; set; }
        public string UnitOwnersId { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public bool Elevator { get; set; }
        public bool Terrace { get; set; }
        public int RoomsNum { get; set; }
        public bool SolarHeater { get; set; }
        public int Furniture { get; set; }
        public bool AirConditioning { get; set; }
        public bool Renovated { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime OccupancyDate { get; set; }
        public int ViewsNum { get; set; }
        public DateTime EvacuationDate { get; set; }
        public bool Relevant { get; set; }

        public virtual TblFurnitureLevel FurnitureNavigation { get; set; }
        public virtual TblUnitOwner UnitOwners { get; set; }
        public virtual TblAnswersForRent TblAnswersForRent { get; set; }
        public virtual TblHousingUnitImage TblHousingUnitImage { get; set; }
        public virtual ICollection<TblFeedback> TblFeedbacks { get; set; }
        public virtual ICollection<TblHousingUnitRelevant> TblHousingUnitRelevants { get; set; }
        public virtual ICollection<TblQuestionsForRent> TblQuestionsForRents { get; set; }
    }
}
