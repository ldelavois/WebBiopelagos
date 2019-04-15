using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TissuePosition
    {
        public TissuePosition()
        {
            ObjectivesBs = new HashSet<ObjectivesBs>();
            PositionSampleType = new HashSet<PositionSampleType>();
            SampleBase = new HashSet<SampleBase>();
            SampleUnknown = new HashSet<SampleUnknown>();
        }

        public string TissuePositionId { get; set; }
        public string TissuePositionDesc { get; set; }

        public ICollection<ObjectivesBs> ObjectivesBs { get; set; }
        public ICollection<PositionSampleType> PositionSampleType { get; set; }
        public ICollection<SampleBase> SampleBase { get; set; }
        public ICollection<SampleUnknown> SampleUnknown { get; set; }
    }
}
