using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FullnessCoeff
    {
        public FullnessCoeff()
        {
            AnalysisStomachContent = new HashSet<AnalysisStomachContent>();
        }

        public byte FullnessCoeffId { get; set; }
        public string FullnessCoeffDesc { get; set; }

        public ICollection<AnalysisStomachContent> AnalysisStomachContent { get; set; }
    }
}
