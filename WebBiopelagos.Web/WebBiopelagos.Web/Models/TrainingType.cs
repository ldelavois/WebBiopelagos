using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TrainingType
    {
        public TrainingType()
        {
            Training = new HashSet<Training>();
        }

        public short TrainingTypeId { get; set; }
        public string TrainingTypeDesc { get; set; }
        public string TrainingTypeFull { get; set; }

        public ICollection<Training> Training { get; set; }
    }
}
