using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class OldTrainingCourse
    {
        public int TrainingCourseId { get; set; }
        public int TrainingId { get; set; }
        public int TrainingModuleId { get; set; }
    }
}
