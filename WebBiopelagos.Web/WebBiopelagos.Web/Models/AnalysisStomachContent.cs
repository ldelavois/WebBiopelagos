using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisStomachContent
    {
        public AnalysisStomachContent()
        {
            AnalysisStomachHardMaterial = new HashSet<AnalysisStomachHardMaterial>();
            AnalysisStomachParasite = new HashSet<AnalysisStomachParasite>();
            AnalysisStomachPreyItem = new HashSet<AnalysisStomachPreyItem>();
        }

        public int AnalysisBaseStomachId { get; set; }
        public double? WholeWeightGr { get; set; }
        public double? CleanedWeightGr { get; set; }
        public double? ContentWeightGr { get; set; }
        public byte? FullnessCoeffId { get; set; }
        public short? BaitNb { get; set; }
        public double? BaitWeightGr { get; set; }
        public string StomachStatusId { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisBase Analysis { get; set; }
        public FullnessCoeff FullnessCoeff { get; set; }
        public StomachStatus StomachStatus { get; set; }
        public ICollection<AnalysisStomachHardMaterial> AnalysisStomachHardMaterial { get; set; }
        public ICollection<AnalysisStomachParasite> AnalysisStomachParasite { get; set; }
        public ICollection<AnalysisStomachPreyItem> AnalysisStomachPreyItem { get; set; }
    }
}
