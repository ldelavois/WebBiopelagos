using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class OtolithSectionType
    {
        public OtolithSectionType()
        {
            AnalysisAging = new HashSet<AnalysisAging>();
        }

        public string OtolithSectionTypeId { get; set; }
        public string OtolithSectionTypeDesc { get; set; }

        public ICollection<AnalysisAging> AnalysisAging { get; set; }
    }
}
