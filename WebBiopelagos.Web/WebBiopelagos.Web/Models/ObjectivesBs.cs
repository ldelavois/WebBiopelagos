using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ObjectivesBs
    {
        public int ObjectivesBsId { get; set; }
        public int ObjectivesSpecimenId { get; set; }
        public string TissueTypeId { get; set; }
        public string TissuePositionId { get; set; }
        public short NbSamples { get; set; }

        public ObjectivesSpecimen ObjectivesSpecimen { get; set; }
        public PositionSampleType Tissue { get; set; }
        public TissuePosition TissuePosition { get; set; }
        public TissueType TissueType { get; set; }
    }
}
