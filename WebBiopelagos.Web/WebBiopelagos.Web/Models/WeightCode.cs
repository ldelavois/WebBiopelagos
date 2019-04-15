using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class WeightCode
    {
        public WeightCode()
        {
            Fish = new HashSet<Fish>();
        }

        public string WeightCodeId { get; set; }
        public string WeightCodeDesc { get; set; }

        public ICollection<Fish> Fish { get; set; }
    }
}
