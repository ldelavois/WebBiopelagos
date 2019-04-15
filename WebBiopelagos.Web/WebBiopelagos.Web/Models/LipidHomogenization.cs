using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class LipidHomogenization
    {
        public LipidHomogenization()
        {
            AnalysisLipid = new HashSet<AnalysisLipid>();
        }

        public string LipidHomogenizationId { get; set; }
        public string LipidHomogenizationDesc { get; set; }

        public ICollection<AnalysisLipid> AnalysisLipid { get; set; }
    }
}
