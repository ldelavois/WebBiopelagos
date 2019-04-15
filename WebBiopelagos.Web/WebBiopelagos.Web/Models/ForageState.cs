using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class ForageState
    {
        public ForageState()
        {
            ForageItem = new HashSet<ForageItem>();
        }

        public byte ForageStateId { get; set; }
        public string ForageStateDesc { get; set; }

        public ICollection<ForageItem> ForageItem { get; set; }
    }
}
