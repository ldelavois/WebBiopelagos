using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class SourceVolumeFiltered
    {
        public SourceVolumeFiltered()
        {
            SetBiologicalStep = new HashSet<SetBiologicalStep>();
        }

        public byte SourceVolumeFilteredId { get; set; }
        public string SourceVolumeFilteredDesc { get; set; }

        public ICollection<SetBiologicalStep> SetBiologicalStep { get; set; }
    }
}
