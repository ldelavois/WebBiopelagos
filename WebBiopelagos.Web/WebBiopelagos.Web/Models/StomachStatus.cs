using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class StomachStatus
    {
        public StomachStatus()
        {
            AnalysisStomachContent = new HashSet<AnalysisStomachContent>();
        }

        public string StomachStatusId { get; set; }
        public string StomachStatusDesc { get; set; }

        public ICollection<AnalysisStomachContent> AnalysisStomachContent { get; set; }
    }
}
