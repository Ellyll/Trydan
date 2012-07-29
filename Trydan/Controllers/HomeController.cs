using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Trydan;
using NHibernate.Tool.hbm2ddl;

namespace Controllers
{
	[HandleError]
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			var sessionFactory = CreateSessionFactory();
			
			IEnumerable<Payment> payments; // = new List<Payment>();
			IEnumerable<Reading> readings; // = new List<Reading>();
			
			using (var session = sessionFactory.OpenSession())
			{
			    using (var transaction = session.BeginTransaction())
			    {
					payments = session.CreateCriteria(typeof(Payment)).List<Payment>();
					readings = session.CreateCriteria(typeof(Reading)).List<Reading>();
				}
			}
			
			var model = new IndexViewModel(payments, readings);
			
			//ViewData ["Message"] = "Welcome to ASP.NET MVC on Mono!" + " " + test;
			return View (model);
		}

		private static ISessionFactory CreateSessionFactory()
		{
			return Fluently.Configure()
				       .Database(
                                  MySQLConfiguration.Standard.ConnectionString(
					c => c.Server("127.0.0.1")
					      .Database("Trydan")
					      .Username("Trydan")
					      .Password("SparkleSparkleZap!")
					     )
					//c => c.FromConnectionStringWithKey("ConnectionString"))
                                )
                       .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ReadingMap>())
					   //.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true,true)) 
                       .BuildSessionFactory();
		}

	}
	
}

