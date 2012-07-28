using System;

namespace Trydan
{
	public class Reading
	{
		public virtual int Id { get; private set; }
		public virtual DateTime TakenOn { get; private set; }
		public virtual decimal Value { get; private set; }
		public virtual decimal Balance { get; private set; }
		
		public Reading()
		{
		}
	}
}

