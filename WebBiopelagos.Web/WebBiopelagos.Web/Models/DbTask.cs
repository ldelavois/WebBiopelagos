using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class DbTask
    {
        public int DbTaskId { get; set; }
        public string TaskType { get; set; }
        public string TaskDesc { get; set; }
        public string FileComplete { get; set; }
        public string Tasker { get; set; }
        public short RecordNb { get; set; }
        public DateTime TaskDate { get; set; }
    }
}
