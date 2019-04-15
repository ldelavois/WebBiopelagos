using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisSampleType
    {
        public AnalysisSampleType()
        {
            AnalysisBase = new HashSet<AnalysisBase>();
        }

        public short AnalysisSampleId { get; set; }
        public string TissueTypeId { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisType AnalysisType { get; set; }
        public TissueType TissueType { get; set; }
        public ICollection<AnalysisBase> AnalysisBase { get; set; }
    }
}
