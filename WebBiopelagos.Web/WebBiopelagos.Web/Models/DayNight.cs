using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class DayNight
    {
        public DayNight()
        {
            SetBase = new HashSet<SetBase>();
            SetBiological = new HashSet<SetBiological>();
        }

        public string DayNightId { get; set; }

        public ICollection<SetBase> SetBase { get; set; }
        public ICollection<SetBiological> SetBiological { get; set; }
    }
}
