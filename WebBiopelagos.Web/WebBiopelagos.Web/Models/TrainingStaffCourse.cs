using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class TrainingStaffCourse
    {
        public int TrainingStaffCourseId { get; set; }
        public int TrainingStaffId { get; set; }
        public int? TrainingCourseIdOld { get; set; }
        public short TrainingModuleId { get; set; }
        public double? CourseResult { get; set; }
        public string CourseDetails { get; set; }

        public TrainingModule TrainingModule { get; set; }
        public TrainingStaff TrainingStaff { get; set; }
    }
}
