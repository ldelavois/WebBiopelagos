using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class DbSamplingFile
    {
        public int DbSamplingFileId { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string Trip { get; set; }
        public string Loader { get; set; }
        public short LoadingOption { get; set; }
        public DateTime LoadingDate { get; set; }
    }
}
