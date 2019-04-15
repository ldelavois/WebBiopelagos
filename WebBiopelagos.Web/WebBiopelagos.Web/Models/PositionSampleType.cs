using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class PositionSampleType
    {
        public PositionSampleType()
        {
            ObjectivesBs = new HashSet<ObjectivesBs>();
            SampleBase = new HashSet<SampleBase>();
            SampleUnknown = new HashSet<SampleUnknown>();
        }

        public short PositionSampleId { get; set; }
        public string TissueTypeId { get; set; }
        public string TissuePositionId { get; set; }

        public TissuePosition TissuePosition { get; set; }
        public TissueType TissueType { get; set; }
        public ICollection<ObjectivesBs> ObjectivesBs { get; set; }
        public ICollection<SampleBase> SampleBase { get; set; }
        public ICollection<SampleUnknown> SampleUnknown { get; set; }
    }
}
