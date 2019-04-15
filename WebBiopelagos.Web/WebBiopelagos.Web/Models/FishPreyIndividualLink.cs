using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FishPreyIndividualLink
    {
        public int FishId { get; set; }
        public int AnalysisStomachPreyIndividualId { get; set; }
        public DateTime CreationDate { get; set; }

        public AnalysisStomachPreyIndividual AnalysisStomachPreyIndividual { get; set; }
        public Fish Fish { get; set; }
    }
}
