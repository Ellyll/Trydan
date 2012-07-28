using System;

namespace Trydan
{
	public class Payment
	{
		public virtual int Id { get; private set; }
		public virtual decimal Amount { get; private set; }
		public virtual DateTime MadeOn { get; private set; }
		public virtual Reading AssociatedReading { get; private set; }
		
		public Payment()
		{
		}
	}
}

