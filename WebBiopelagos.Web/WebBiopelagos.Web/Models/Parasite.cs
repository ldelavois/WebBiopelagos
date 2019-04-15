using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Parasite
    {
        public Parasite()
        {
            AnalysisStomachParasite = new HashSet<AnalysisStomachParasite>();
        }

        public byte ParasiteId { get; set; }
        public string ParasiteDesc { get; set; }

        public ICollection<AnalysisStomachParasite> AnalysisStomachParasite { get; set; }
    }
}
