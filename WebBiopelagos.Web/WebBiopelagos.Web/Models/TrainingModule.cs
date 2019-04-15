using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TrainingModule
    {
        public TrainingModule()
        {
            TrainingStaffCourse = new HashSet<TrainingStaffCourse>();
        }

        public short TrainingModuleId { get; set; }
        public string TrainingModuleDesc { get; set; }
        public string TrainingModuleFull { get; set; }

        public ICollection<TrainingStaffCourse> TrainingStaffCourse { get; set; }
    }
}
