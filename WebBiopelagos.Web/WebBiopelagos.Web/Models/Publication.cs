using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class Publication
    {
        public Publication()
        {
            PublicationAnalysisLink = new HashSet<PublicationAnalysisLink>();
        }

        public short PublicationId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public DateTime IssuedDate { get; set; }
        public string PublisherName { get; set; }
        public string Doi { get; set; }
        public string Url { get; set; }
        public DateTime CreationDate { get; set; }

        public ICollection<PublicationAnalysisLink> PublicationAnalysisLink { get; set; }
    }
}
