using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class PublicationAnalysisLink
    {
        public short PublicationId { get; set; }
        public int AnalysisBaseId { get; set; }

        public AnalysisBase AnalysisBase { get; set; }
        public Publication Publication { get; set; }
    }
}
