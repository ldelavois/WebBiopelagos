using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class MicroscopicStage
    {
        public MicroscopicStage()
        {
            AnalysisHistology = new HashSet<AnalysisHistology>();
        }

        public string MicroscopicStageId { get; set; }
        public string MicroscopicStageDesc { get; set; }

        public ICollection<AnalysisHistology> AnalysisHistology { get; set; }
    }
}
