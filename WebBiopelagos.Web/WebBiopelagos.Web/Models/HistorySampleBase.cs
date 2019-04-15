using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class HistorySampleBase
    {
        public int HistorySampleBaseId { get; set; }
        public int SampleBaseId { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsLost { get; set; }
        public bool IsDiscarded { get; set; }
        public string TissuePositionId { get; set; }
        public string TissueConditionId { get; set; }
        public string StorageQualityId { get; set; }
        public short? QualityStaffId { get; set; }
        public DateTime? LocationDate { get; set; }
        public short? InventoryLocationId { get; set; }
        public DateTime? InventoryDate { get; set; }
        public byte? FreezerLocationId { get; set; }
        public string LocationDetails { get; set; }
        public DateTime UpdatedDate { get; set; }

        public SampleBase SampleBase { get; set; }
    }
}
