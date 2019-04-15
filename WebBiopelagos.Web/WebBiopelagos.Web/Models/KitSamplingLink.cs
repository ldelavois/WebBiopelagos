using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class KitSamplingLink
    {
        public int KitSamplingLinkId { get; set; }
        public int SamplingId { get; set; }
        public int SamplingKitId { get; set; }

        public Sampling Sampling { get; set; }
        public SamplingKit SamplingKit { get; set; }
    }
}
