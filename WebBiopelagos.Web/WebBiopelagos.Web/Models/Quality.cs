using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Quality
    {
        public Quality()
        {
            AnalysisAging = new HashSet<AnalysisAging>();
            SamplingBsFormQuality = new HashSet<Sampling>();
            SamplingInstructionsQuality = new HashSet<Sampling>();
            SamplingPackagingQuality = new HashSet<Sampling>();
        }

        public string QualityId { get; set; }
        public string QualityDesc { get; set; }

        public ICollection<AnalysisAging> AnalysisAging { get; set; }
        public ICollection<Sampling> SamplingBsFormQuality { get; set; }
        public ICollection<Sampling> SamplingInstructionsQuality { get; set; }
        public ICollection<Sampling> SamplingPackagingQuality { get; set; }
    }
}
