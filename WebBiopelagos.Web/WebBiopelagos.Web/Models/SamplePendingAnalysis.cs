using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SamplePendingAnalysis
    {
        public int SamplePendingAnalysisId { get; set; }
        public int SampleBaseId { get; set; }
        public short? ContractId { get; set; }
        public DateTime GivenDate { get; set; }
        public string VolumeSamplingFreightId { get; set; }
        public short LaboratoryLocationId { get; set; }
        public short ContactStaffId { get; set; }
        public string AnalysisTypeId { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public bool IsAnalysisReceived { get; set; }
        public bool IsSampleReturned { get; set; }
        public DateTime? CreationDate { get; set; }
        public byte? LaboratoryIdOld { get; set; }
        public string ContactNameOld { get; set; }

        public AnalysisType AnalysisType { get; set; }
        public Staff ContactStaff { get; set; }
        public Contract Contract { get; set; }
        public Location LaboratoryLocation { get; set; }
        public SampleBase SampleBase { get; set; }
        public VolumeSamplingFreight VolumeSamplingFreight { get; set; }
    }
}
