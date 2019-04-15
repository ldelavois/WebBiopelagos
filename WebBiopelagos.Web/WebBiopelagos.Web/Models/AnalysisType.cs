using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisType
    {
        public AnalysisType()
        {
            AnalysisBase = new HashSet<AnalysisBase>();
            AnalysisSampleType = new HashSet<AnalysisSampleType>();
            SamplePendingAnalysis = new HashSet<SamplePendingAnalysis>();
        }

        public string AnalysisTypeId { get; set; }
        public string AnalysisTypeDesc { get; set; }
        public string AnalysisColor { get; set; }

        public ICollection<AnalysisBase> AnalysisBase { get; set; }
        public ICollection<AnalysisSampleType> AnalysisSampleType { get; set; }
        public ICollection<SamplePendingAnalysis> SamplePendingAnalysis { get; set; }
    }
}
