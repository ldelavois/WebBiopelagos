using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SampleBase
    {
        public SampleBase()
        {
            AnalysisBase = new HashSet<AnalysisBase>();
            ChildSpecimenSampleLink = new HashSet<ChildSpecimenSampleLink>();
            DbTransfer = new HashSet<DbTransfer>();
            FreightSampleLink = new HashSet<FreightSampleLink>();
            HistorySampleBase = new HashSet<HistorySampleBase>();
            SampleCommunity = new HashSet<SampleCommunity>();
            SampleGonad = new HashSet<SampleGonad>();
            SampleOther = new HashSet<SampleOther>();
            SampleOtolith = new HashSet<SampleOtolith>();
            SamplePendingAnalysis = new HashSet<SamplePendingAnalysis>();
        }

        public int SampleBaseId { get; set; }
        public int FishId { get; set; }
        public string SampleNo { get; set; }
        public short OwnershipLocationId { get; set; }
        public double? PriceUsd { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsLost { get; set; }
        public DateTime? MissingDate { get; set; }
        public bool IsDiscarded { get; set; }
        public bool? IsPendingAnalysis { get; set; }
        public bool? IsAnalyzed { get; set; }
        public string TissueTypeId { get; set; }
        public string TissuePositionId { get; set; }
        public string TissueConditionId { get; set; }
        public string StorageQualityId { get; set; }
        public short? QualityStaffId { get; set; }
        public short? LastLocationId { get; set; }
        public DateTime? LocationDate { get; set; }
        public short? InventoryLocationId { get; set; }
        public DateTime? InventoryDate { get; set; }
        public short? InventoryStaffId { get; set; }
        public byte? FreezerLocationId { get; set; }
        public string LocationDetails { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsTransfered { get; set; }
        public string InventoryLocationIdOld { get; set; }
        public int? TmpId { get; set; }

        public Fish Fish { get; set; }
        public FreezerLocation FreezerLocation { get; set; }
        public Location InventoryLocation { get; set; }
        public Staff InventoryStaff { get; set; }
        public Location OwnershipLocation { get; set; }
        public StorageQuality StorageQuality { get; set; }
        public StorageQualityCondition StorageQualityCondition { get; set; }
        public ConditionSampleType Tissue { get; set; }
        public TissueCondition TissueCondition { get; set; }
        public PositionSampleType TissueNavigation { get; set; }
        public TissuePosition TissuePosition { get; set; }
        public TissueType TissueType { get; set; }
        public ICollection<AnalysisBase> AnalysisBase { get; set; }
        public ICollection<ChildSpecimenSampleLink> ChildSpecimenSampleLink { get; set; }
        public ICollection<DbTransfer> DbTransfer { get; set; }
        public ICollection<FreightSampleLink> FreightSampleLink { get; set; }
        public ICollection<HistorySampleBase> HistorySampleBase { get; set; }
        public ICollection<SampleCommunity> SampleCommunity { get; set; }
        public ICollection<SampleGonad> SampleGonad { get; set; }
        public ICollection<SampleOther> SampleOther { get; set; }
        public ICollection<SampleOtolith> SampleOtolith { get; set; }
        public ICollection<SamplePendingAnalysis> SamplePendingAnalysis { get; set; }
    }
}
