using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ParasiteMode
    {
        public ParasiteMode()
        {
            AnalysisStomachParasite = new HashSet<AnalysisStomachParasite>();
        }

        public byte ParasiteModeId { get; set; }
        public string ParasiteModeDesc { get; set; }

        public ICollection<AnalysisStomachParasite> AnalysisStomachParasite { get; set; }
    }
}
