using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class MagoStage
    {
        public MagoStage()
        {
            AnalysisHistology = new HashSet<AnalysisHistology>();
        }

        public byte MagoStageId { get; set; }
        public string MagoStageDesc { get; set; }

        public ICollection<AnalysisHistology> AnalysisHistology { get; set; }
    }
}
