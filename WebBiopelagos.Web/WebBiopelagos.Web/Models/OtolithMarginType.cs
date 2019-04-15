using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class OtolithMarginType
    {
        public OtolithMarginType()
        {
            AnalysisAging = new HashSet<AnalysisAging>();
        }

        public string OtolithMarginTypeId { get; set; }
        public string OtolithMarginTypeDesc { get; set; }

        public ICollection<AnalysisAging> AnalysisAging { get; set; }
    }
}
