using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FreightOrphanLink
    {
        public int SamplingFreightId { get; set; }
        public int SampleOrphanId { get; set; }

        public SamplingFreight SamplingFreight { get; set; }
    }
}
