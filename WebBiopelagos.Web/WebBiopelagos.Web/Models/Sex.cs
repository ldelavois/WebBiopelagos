using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Sex
    {
        public Sex()
        {
            AnalysisHistology = new HashSet<AnalysisHistology>();
            AnalysisStomachPreyIndividual = new HashSet<AnalysisStomachPreyIndividual>();
            Fish = new HashSet<Fish>();
            ForageIndividual = new HashSet<ForageIndividual>();
        }

        public string SexId { get; set; }
        public string SexDesc { get; set; }

        public ICollection<AnalysisHistology> AnalysisHistology { get; set; }
        public ICollection<AnalysisStomachPreyIndividual> AnalysisStomachPreyIndividual { get; set; }
        public ICollection<Fish> Fish { get; set; }
        public ICollection<ForageIndividual> ForageIndividual { get; set; }
    }
}
