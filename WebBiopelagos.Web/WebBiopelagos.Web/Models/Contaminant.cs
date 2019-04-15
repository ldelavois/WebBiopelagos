using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Contaminant
    {
        public Contaminant()
        {
            AnalysisContaminantComparedContaminant = new HashSet<AnalysisContaminant>();
            AnalysisContaminantContaminant = new HashSet<AnalysisContaminant>();
        }

        public string ContaminantId { get; set; }
        public string ContaminantDesc { get; set; }

        public ICollection<AnalysisContaminant> AnalysisContaminantComparedContaminant { get; set; }
        public ICollection<AnalysisContaminant> AnalysisContaminantContaminant { get; set; }
    }
}
