using System;
using FluentNHibernate.Mapping;

namespace Trydan
{
	public class PaymentMap : ClassMap<Payment>
	{
		public PaymentMap()
		{
			Table("Payment");
			Id(x => x.Id).Column("Id");
			Map(x => x.Amount).Column("Amount");
			Map(x => x.MadeOn).Column("MadeOn");
			References(x => x.AssociatedReading).Column("ReadingId").Nullable();
		}
	}
}

