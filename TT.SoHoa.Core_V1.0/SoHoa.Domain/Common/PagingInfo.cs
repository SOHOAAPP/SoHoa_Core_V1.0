using System;
using System.Collections.Generic;
using System.Text;

namespace SoHoa.Domain.Common
{
    public class PagingInfo
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int PageCount { get; set; }
        public long TotalRecordCount { get; set; }
    }
}
