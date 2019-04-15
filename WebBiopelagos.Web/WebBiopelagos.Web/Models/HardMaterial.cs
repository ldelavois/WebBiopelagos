using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class HardMaterial
    {
        public HardMaterial()
        {
            AnalysisStomachHardMaterial = new HashSet<AnalysisStomachHardMaterial>();
        }

        public byte HardMaterialId { get; set; }
        public string HardMaterialDesc { get; set; }

        public ICollection<AnalysisStomachHardMaterial> AnalysisStomachHardMaterial { get; set; }
    }
}
