using System;
using System.Collections.Generic;
using System.Text;

namespace SoHoa.Domain.Common
{
    public class PageResult<T>
    {
		public List<T> Data { get; private set; }
		public PagingInfo Paging { get; private set; }

		public PageResult(IEnumerable<T> items, int page, int pageSize, long totalRecordCount)
		{
			Data = new List<T>(items);
			Paging = new PagingInfo
			{
				Page = page,
				PageSize = pageSize,
				TotalRecordCount = totalRecordCount,
				PageCount = totalRecordCount > 0
					? (int)Math.Ceiling(totalRecordCount / (double)pageSize)
					: 0
			};
		}
	}
}
