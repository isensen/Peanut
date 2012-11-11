using System;
using System.Collections.Generic;
namespace Peanut
{
	public class FilterContext
	{
		private Queue<FilterAttribute> mFilters = new Queue<FilterAttribute>(16);
		public object Result
		{
			get;
			set;
		}
		public IView View
		{
			get;
			set;
		}
		public FilterContext(IList<FilterAttribute> filters)
		{
			for (int i = 0; i < WebContext.PublicFilters.Count; i++)
			{
				this.mFilters.Enqueue(WebContext.PublicFilters[i]);
			}
			for (int i = 0; i < filters.Count; i++)
			{
				this.mFilters.Enqueue(filters[i]);
			}
		}
		public void Execute()
		{
			if (this.mFilters.Count > 0)
			{
				this.mFilters.Dequeue().Execute(this);
			}
			else
			{
				this.Result = this.View.Execute((RequestType)Enum.Parse(typeof(RequestType), WebContext.Current.Request.RequestType));
			}
		}
	}
}
