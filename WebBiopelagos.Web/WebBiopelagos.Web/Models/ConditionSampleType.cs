using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ConditionSampleType
    {
        public ConditionSampleType()
        {
            SampleBase = new HashSet<SampleBase>();
            SampleUnknown = new HashSet<SampleUnknown>();
        }

        public short ConditionSampleId { get; set; }
        public string TissueTypeId { get; set; }
        public string TissueConditionId { get; set; }

        public TissueCondition TissueCondition { get; set; }
        public TissueType TissueType { get; set; }
        public ICollection<SampleBase> SampleBase { get; set; }
        public ICollection<SampleUnknown> SampleUnknown { get; set; }
    }
}
