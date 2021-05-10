using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.DAL.Models
{
    public partial class TblSearch
    {
        public int SearchId { get; set; }
        public string CustomersId { get; set; }
        public string UnitOwnersId { get; set; }
        public DateTime DateSearch { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int FromFloor { get; set; }
        public int ToFloor { get; set; }
        public bool Elevator { get; set; }
        public bool Terrace { get; set; }
        public int RoomsNum { get; set; }
        public bool SolarHeater { get; set; }
        public int Furniture { get; set; }
        public bool AirConditioning { get; set; }
        public bool Renovated { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime OccupancyDate { get; set; }
        public int ViewsNum { get; set; }
        public DateTime EvacuationDate { get; set; }
        public bool Relevant { get; set; }

        public virtual TblCustomer Customers { get; set; }
        public virtual TblFurnitureLevel FurnitureNavigation { get; set; }
        public virtual TblUnitOwner UnitOwners { get; set; }
    }
}
