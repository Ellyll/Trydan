using System;
using FluentNHibernate.Mapping;

namespace Trydan
{
	public class ReadingMap : ClassMap<Reading>
	{
		public ReadingMap()
		{
			Table("Reading");
			Id(x => x.Id).Column("Id");
			Map(x => x.TakenOn).Column("TakenOn");
			Map(x => x.Value).Column("Value");
			Map(x => x.Balance).Column("Balance");
		}
	}
}

