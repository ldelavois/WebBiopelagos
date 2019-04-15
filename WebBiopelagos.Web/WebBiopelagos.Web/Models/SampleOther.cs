using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SampleOther
    {
        public int SampleBaseId { get; set; }
        public string SampleType { get; set; }
        public string TissueTypeId { get; set; }

        public SampleBase SampleBase { get; set; }
        public TissueType TissueType { get; set; }
    }
}
