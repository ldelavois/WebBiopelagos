using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SampleCommunity
    {
        public int SampleBaseId { get; set; }
        public byte ProportionInitialSample { get; set; }
        public string TissueTypeId { get; set; }

        public SampleBase SampleBase { get; set; }
        public TissueType TissueType { get; set; }
    }
}
