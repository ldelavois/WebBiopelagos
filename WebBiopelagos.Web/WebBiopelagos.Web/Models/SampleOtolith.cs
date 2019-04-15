using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SampleOtolith
    {
        public int SampleBaseId { get; set; }
        public bool IsPrepared { get; set; }
        public string TissueTypeId { get; set; }

        public SampleBase SampleBase { get; set; }
        public TissueType TissueType { get; set; }
    }
}
