using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FreightSamplingLink
    {
        public int SamplingFreightId { get; set; }
        public int SamplingId { get; set; }
        public string VolumeSamplingFreightId { get; set; }

        public Sampling Sampling { get; set; }
        public SamplingFreight SamplingFreight { get; set; }
        public VolumeSamplingFreight VolumeSamplingFreight { get; set; }
    }
}
