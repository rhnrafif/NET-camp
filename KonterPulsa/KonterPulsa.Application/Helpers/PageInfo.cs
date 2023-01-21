using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonterPulsa.Application.Helpers
{
	public class PageInfo
	{
		public int page { get; set; }
		public int limit { get; set; }
		private int skip
		{
			get
			{
				return limit * (page - 1);
			}
		}

		public PageInfo(int page, int limit)
		{
			this.page = page;
			this.limit = limit;
		}
		public PageInfo()
		{

		}
	}
}
