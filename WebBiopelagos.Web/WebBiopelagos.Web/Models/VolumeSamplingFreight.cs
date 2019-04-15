using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class VolumeSamplingFreight
    {
        public VolumeSamplingFreight()
        {
            FreightSamplingLink = new HashSet<FreightSamplingLink>();
            SamplePendingAnalysis = new HashSet<SamplePendingAnalysis>();
        }

        public string VolumeSamplingFreightId { get; set; }
        public string VolumeSamplingFreightDesc { get; set; }

        public ICollection<FreightSamplingLink> FreightSamplingLink { get; set; }
        public ICollection<SamplePendingAnalysis> SamplePendingAnalysis { get; set; }
    }
}
