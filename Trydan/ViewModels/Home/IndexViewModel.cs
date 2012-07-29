using System;
using System.Collections.Generic;

namespace Trydan
{
	public class IndexViewModel
	{
		public IEnumerable<Payment> RecentPayments;
		public IEnumerable<Reading> RecentReadings;
		
		public IndexViewModel(IEnumerable<Payment> recentPayments, IEnumerable<Reading> recentReadings)
		{
			this.RecentPayments = recentPayments;
			this.RecentReadings = recentReadings;
		}
	}
}

