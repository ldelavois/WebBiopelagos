using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class StorageQuality
    {
        public StorageQuality()
        {
            SampleBase = new HashSet<SampleBase>();
            SampleUnknown = new HashSet<SampleUnknown>();
            StorageQualityCondition = new HashSet<StorageQualityCondition>();
        }

        public string StorageQualityId { get; set; }
        public string StorageQualityDesc { get; set; }
        public bool OoWeight { get; set; }

        public ICollection<SampleBase> SampleBase { get; set; }
        public ICollection<SampleUnknown> SampleUnknown { get; set; }
        public ICollection<StorageQualityCondition> StorageQualityCondition { get; set; }
    }
}
