using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Gear
    {
        public Gear()
        {
            SetBase = new HashSet<SetBase>();
        }

        public string GearId { get; set; }
        public string GearDesc { get; set; }
        public string GearTubs { get; set; }

        public ICollection<SetBase> SetBase { get; set; }
    }
}
