using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TowMethod
    {
        public TowMethod()
        {
            SetBiological = new HashSet<SetBiological>();
        }

        public string TowMethodId { get; set; }
        public string TowMethodDesc { get; set; }

        public ICollection<SetBiological> SetBiological { get; set; }
    }
}
