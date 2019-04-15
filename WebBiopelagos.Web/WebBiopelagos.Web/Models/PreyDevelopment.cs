using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class PreyDevelopment
    {
        public PreyDevelopment()
        {
            AnalysisStomachPreyItem = new HashSet<AnalysisStomachPreyItem>();
            ForageItem = new HashSet<ForageItem>();
        }

        public string PreyDevelopmentId { get; set; }
        public string PreyDevelopmentDesc { get; set; }

        public ICollection<AnalysisStomachPreyItem> AnalysisStomachPreyItem { get; set; }
        public ICollection<ForageItem> ForageItem { get; set; }
    }
}
