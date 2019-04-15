using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class FishType
    {
        public FishType()
        {
            Fish = new HashSet<Fish>();
        }

        public string FishTypeId { get; set; }
        public string FishTypeDesc { get; set; }

        public ICollection<Fish> Fish { get; set; }
    }
}
