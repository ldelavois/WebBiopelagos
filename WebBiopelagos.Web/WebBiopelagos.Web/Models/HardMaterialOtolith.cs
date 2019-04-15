using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class HardMaterialOtolith
    {
        public HardMaterialOtolith()
        {
            AnalysisStomachHardMaterial = new HashSet<AnalysisStomachHardMaterial>();
        }

        public byte HardMaterialOtolithId { get; set; }
        public string HardMaterialOtolithDesc { get; set; }

        public ICollection<AnalysisStomachHardMaterial> AnalysisStomachHardMaterial { get; set; }
    }
}
