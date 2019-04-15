using System;
using System.Collections.Generic;

namespace WebBiopelagos.Web.Models
{
    public partial class RefStockType
    {
        public RefStockType()
        {
            Movement = new HashSet<Movement>();
        }

        public byte StockTypeId { get; set; }
        public string StockTypeDesc { get; set; }
        public string StockTypeFull { get; set; }

        public ICollection<Movement> Movement { get; set; }
    }
}
