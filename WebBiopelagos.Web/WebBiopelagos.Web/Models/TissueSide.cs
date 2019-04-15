using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TissueSide
    {
        public TissueSide()
        {
            AnalysisLipid = new HashSet<AnalysisLipid>();
        }

        public string TissueSideId { get; set; }
        public string TissueSideDesc { get; set; }

        public ICollection<AnalysisLipid> AnalysisLipid { get; set; }
    }
}
