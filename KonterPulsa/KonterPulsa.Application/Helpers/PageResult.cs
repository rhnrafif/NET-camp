using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonterPulsa.Application.Helpers
{
	public class PageResult<T>
	{
		public PageResult(IEnumerable<T> data, long total)
		{
			Data = data;
			Total = total;
		}

		public PageResult() { }

		public IEnumerable<T> Data { get; set; }
		public long Total { get; set; }
	}
}
