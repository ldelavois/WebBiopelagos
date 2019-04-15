using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class StorageQualityCondition
    {
        public StorageQualityCondition()
        {
            SampleBase = new HashSet<SampleBase>();
        }

        public short StorageConditionId { get; set; }
        public string TissueConditionId { get; set; }
        public string StorageQualityId { get; set; }

        public StorageQuality StorageQuality { get; set; }
        public TissueCondition TissueCondition { get; set; }
        public ICollection<SampleBase> SampleBase { get; set; }
    }
}
