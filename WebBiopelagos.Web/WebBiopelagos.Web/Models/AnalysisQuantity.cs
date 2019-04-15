using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class AnalysisQuantity
    {
        public int AnalysisBaseId { get; set; }
        public double QunatityValue { get; set; }
        public string QuantityUnit { get; set; }
        public string Comment { get; set; }
        public string SubAnalysisType { get; set; }
        public string AnalysisTypeId { get; set; }

        public AnalysisBase Analysis { get; set; }
    }
}
