using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TissueCondition
    {
        public TissueCondition()
        {
            ConditionSampleType = new HashSet<ConditionSampleType>();
            SampleBase = new HashSet<SampleBase>();
            SampleUnknown = new HashSet<SampleUnknown>();
            StorageQualityCondition = new HashSet<StorageQualityCondition>();
        }

        public string TissueConditionId { get; set; }
        public string TissueConditionDesc { get; set; }

        public ICollection<ConditionSampleType> ConditionSampleType { get; set; }
        public ICollection<SampleBase> SampleBase { get; set; }
        public ICollection<SampleUnknown> SampleUnknown { get; set; }
        public ICollection<StorageQualityCondition> StorageQualityCondition { get; set; }
    }
}
