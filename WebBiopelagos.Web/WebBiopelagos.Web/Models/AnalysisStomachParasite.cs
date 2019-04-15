using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisStomachParasite
    {
        public int AnalysisStomachParasiteId { get; set; }
        public int AnalysisBaseStomachId { get; set; }
        public byte ParasiteId { get; set; }
        public byte ParasiteModeId { get; set; }
        public short ParasiteNb { get; set; }

        public AnalysisStomachContent AnalysisBaseStomach { get; set; }
        public Parasite Parasite { get; set; }
        public ParasiteMode ParasiteMode { get; set; }
    }
}
