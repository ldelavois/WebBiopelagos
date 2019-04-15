using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SampleUnknown
    {
        public int SampleUnknownId { get; set; }
        public string SampleNo { get; set; }
        public string TissueTypeId { get; set; }
        public string TissuePositionId { get; set; }
        public string TissueConditionId { get; set; }
        public string StorageQualityId { get; set; }
        public DateTime? ReceptionDate { get; set; }
        public int? SamplingFreightId { get; set; }
        public short InventoryLocationId { get; set; }
        public short? InventoryStaffId { get; set; }
        public short? OwnershipLocationId { get; set; }
        public DateTime InventoryDate { get; set; }
        public byte? FreezerLocationId { get; set; }
        public string LocationDetails { get; set; }
        public string FromCountryCodeId { get; set; }
        public string KitGivenTo { get; set; }
        public DateTime? KitGivenDate { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }

        public FreezerLocation FreezerLocation { get; set; }
        public Country FromCountryCode { get; set; }
        public Location InventoryLocation { get; set; }
        public Staff InventoryStaff { get; set; }
        public Location OwnershipLocation { get; set; }
        public SamplingFreight SamplingFreight { get; set; }
        public StorageQuality StorageQuality { get; set; }
        public ConditionSampleType Tissue { get; set; }
        public TissueCondition TissueCondition { get; set; }
        public PositionSampleType TissueNavigation { get; set; }
        public TissuePosition TissuePosition { get; set; }
        public TissueType TissueType { get; set; }
    }
}
