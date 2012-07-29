using System;
using System.Collections.Generic;

namespace Trydan
{
	public class RecentPaymentsViewModel
	{
		public IEnumerable<Payment> Payments { get; set; }
		
		public RecentPaymentsViewModel(IEnumerable<Payment> payments)
		{
			this.Payments = payments;
		}
	}
}

