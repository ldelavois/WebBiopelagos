using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Trip
    {
        public Trip()
        {
            Debriefing = new HashSet<Debriefing>();
            SetBase = new HashSet<SetBase>();
            TripTubsLink = new HashSet<TripTubsLink>();
        }

        public int TripId { get; set; }
        public byte TripTypeId { get; set; }
        public string TripName { get; set; }
        public string TripNo { get; set; }
        public string AlternateTripName { get; set; }
        public string TagdagerNo { get; set; }
        public Guid? T2TripId { get; set; }
        public string ObsprgCode { get; set; }
        public string CountryCodeId { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string DepartureLocationCode { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string ReturnLocationCode { get; set; }
        public string VesselName { get; set; }
        public string GearId { get; set; }
        public string CountryFlagId { get; set; }
        public short SamplerStaffId { get; set; }
        public short? SamplerStaffId2 { get; set; }
        public short? SamplerStaffId3 { get; set; }
        public string Comment { get; set; }
        public bool IsDbChecked { get; set; }
        public byte? CheckingStatus { get; set; }
        public string CheckerName { get; set; }
        public DateTime? CheckDate { get; set; }
        public string CheckComment { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? ObstripIdOld { get; set; }

        public Country CountryCode { get; set; }
        public Port DepartureLocationCodeNavigation { get; set; }
        public Port ReturnLocationCodeNavigation { get; set; }
        public Staff SamplerStaff { get; set; }
        public Staff SamplerStaffId2Navigation { get; set; }
        public Staff SamplerStaffId3Navigation { get; set; }
        public TripType TripType { get; set; }
        public Sampling Sampling { get; set; }
        public ICollection<Debriefing> Debriefing { get; set; }
        public ICollection<SetBase> SetBase { get; set; }
        public ICollection<TripTubsLink> TripTubsLink { get; set; }
    }
}
