using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SampleGonad
    {
        public int SampleBaseId { get; set; }
        public bool IsBlockPrepared { get; set; }
        public short? WeightGr { get; set; }
        public double? GonadIndex { get; set; }
        public string TissueTypeId { get; set; }

        public SampleBase SampleBase { get; set; }
        public TissueType TissueType { get; set; }
    }
}
