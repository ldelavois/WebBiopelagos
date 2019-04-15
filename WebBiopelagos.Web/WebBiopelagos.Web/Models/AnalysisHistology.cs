using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisHistology
    {
        public AnalysisHistology()
        {
            AnalysisHistologyData = new HashSet<AnalysisHistologyData>();
        }

        public int AnalysisBaseHistologyId { get; set; }
        public string SexId { get; set; }
        public string MicroscopicStageId { get; set; }
        public bool IsMature { get; set; }
        public bool IsActive { get; set; }
        public bool IsPof { get; set; }
        public double? BatchFecundity { get; set; }
        public double? RelativeFecundity { get; set; }
        public byte? MagoStageId { get; set; }
        public double? MagoDiameter { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisBase AnalysisBaseHistology { get; set; }
        public MagoStage MagoStage { get; set; }
        public MicroscopicStage MicroscopicStage { get; set; }
        public Sex Sex { get; set; }
        public ICollection<AnalysisHistologyData> AnalysisHistologyData { get; set; }
    }
}
