using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TissueType
    {
        public TissueType()
        {
            AnalysisSampleType = new HashSet<AnalysisSampleType>();
            ConditionSampleType = new HashSet<ConditionSampleType>();
            ObjectivesBs = new HashSet<ObjectivesBs>();
            PositionSampleType = new HashSet<PositionSampleType>();
            SampleBase = new HashSet<SampleBase>();
            SampleCommunity = new HashSet<SampleCommunity>();
            SampleGonad = new HashSet<SampleGonad>();
            SampleOther = new HashSet<SampleOther>();
            SampleOtolith = new HashSet<SampleOtolith>();
            SampleUnknown = new HashSet<SampleUnknown>();
        }

        public string TissueTypeId { get; set; }
        public string TissueTypeDesc { get; set; }
        public string TissueTypeGroup { get; set; }
        public string TissueColor { get; set; }
        public bool IsWeb { get; set; }

        public ICollection<AnalysisSampleType> AnalysisSampleType { get; set; }
        public ICollection<ConditionSampleType> ConditionSampleType { get; set; }
        public ICollection<ObjectivesBs> ObjectivesBs { get; set; }
        public ICollection<PositionSampleType> PositionSampleType { get; set; }
        public ICollection<SampleBase> SampleBase { get; set; }
        public ICollection<SampleCommunity> SampleCommunity { get; set; }
        public ICollection<SampleGonad> SampleGonad { get; set; }
        public ICollection<SampleOther> SampleOther { get; set; }
        public ICollection<SampleOtolith> SampleOtolith { get; set; }
        public ICollection<SampleUnknown> SampleUnknown { get; set; }
    }
}
