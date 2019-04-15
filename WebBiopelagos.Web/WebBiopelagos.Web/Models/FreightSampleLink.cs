using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FreightSampleLink
    {
        public int SamplingFreightId { get; set; }
        public int SampleBaseId { get; set; }
        public string VolumeSamplingFreightId { get; set; }
        public DateTime CreationDate { get; set; }

        public SampleBase SampleBase { get; set; }
        public SamplingFreight SamplingFreight { get; set; }
    }
}
