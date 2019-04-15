using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class CodendType
    {
        public CodendType()
        {
            SetBiologicalGear = new HashSet<SetBiologicalGear>();
        }

        public byte CodendTypeId { get; set; }
        public string CodendTypeDesc { get; set; }

        public ICollection<SetBiologicalGear> SetBiologicalGear { get; set; }
    }
}
