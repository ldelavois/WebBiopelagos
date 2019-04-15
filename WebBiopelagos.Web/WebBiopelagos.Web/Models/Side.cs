using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Side
    {
        public Side()
        {
            AnalysisAging = new HashSet<AnalysisAging>();
        }

        public string SideId { get; set; }
        public string SideDesc { get; set; }

        public ICollection<AnalysisAging> AnalysisAging { get; set; }
    }
}
