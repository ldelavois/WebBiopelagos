using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisStomachHardMaterial
    {
        public int AnalysisStomachHardMaterialId { get; set; }
        public int AnalysisBaseStomachId { get; set; }
        public byte HardMaterialId { get; set; }
        public int HardMaterialNb { get; set; }
        public byte? HardMaterialOtolithId { get; set; }

        public AnalysisStomachContent AnalysisBaseStomach { get; set; }
        public HardMaterial HardMaterial { get; set; }
        public HardMaterialOtolith HardMaterialOtolith { get; set; }
    }
}
