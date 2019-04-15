using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ChildSpecimenSampleLink
    {
        public int ParentSampleBaseId { get; set; }
        public int ChildSpecimenId { get; set; }
        public DateTime CreationDate { get; set; }

        public Fish ChildSpecimen { get; set; }
        public SampleBase ParentSampleBase { get; set; }
    }
}
