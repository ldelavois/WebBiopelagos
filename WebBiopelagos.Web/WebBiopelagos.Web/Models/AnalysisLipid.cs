using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisLipid
    {
        public AnalysisLipid()
        {
            AnalysisLipidData = new HashSet<AnalysisLipidData>();
        }

        public int AnalysisBaseLipidId { get; set; }
        public string CalibrationId { get; set; }
        public int LabSampleCode { get; set; }
        public string TissueSideId { get; set; }
        public string LipidHomogenizationId { get; set; }
        public double? TissueWeightGr { get; set; }
        public double? LipidWeightMgr { get; set; }
        public double? LipidProportion { get; set; }
        public DateTime? ClassAnalysisDate { get; set; }
        public double? TagClass { get; set; }
        public double? FfaClass { get; set; }
        public double? StClass { get; set; }
        public double? PlClass { get; set; }
        public bool IsValid { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisBase Analysis { get; set; }
        public LipidHomogenization LipidHomogenization { get; set; }
        public TissueSide TissueSide { get; set; }
        public ICollection<AnalysisLipidData> AnalysisLipidData { get; set; }
    }
}
