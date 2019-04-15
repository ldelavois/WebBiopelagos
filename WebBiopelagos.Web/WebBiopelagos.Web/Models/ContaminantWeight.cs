using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ContaminantWeight
    {
        public ContaminantWeight()
        {
            AnalysisContaminant = new HashSet<AnalysisContaminant>();
        }

        public string ContaminantWeightId { get; set; }
        public string ContaminantWeightDesc { get; set; }

        public ICollection<AnalysisContaminant> AnalysisContaminant { get; set; }
    }
}
