using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class CabinetOo
    {
        public byte CabinetOoId { get; set; }
        public string AsfisCode { get; set; }
        public string SpeciesRack { get; set; }
        public string Cabinet { get; set; }
        public byte NbRacks { get; set; }
        public byte Size { get; set; }
    }
}
