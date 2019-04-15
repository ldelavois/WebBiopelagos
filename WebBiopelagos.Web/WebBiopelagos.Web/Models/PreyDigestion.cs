using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class PreyDigestion
    {
        public PreyDigestion()
        {
            AnalysisStomachPreyItem = new HashSet<AnalysisStomachPreyItem>();
        }

        public byte PreyDigestionId { get; set; }
        public string PreyDigestionDesc { get; set; }

        public ICollection<AnalysisStomachPreyItem> AnalysisStomachPreyItem { get; set; }
    }
}
